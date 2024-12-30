using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Final_AdvanceTech
{
    public partial class Inventory : Form
    {
        private string connectionString = "Data Source=LAPTOP-HK44U3IK;Initial Catalog=Resaurant_system;Integrated Security=True;TrustServerCertificate=True;";

        public Inventory()
        {
            InitializeComponent();
        }

        private void InitializeChart()
        {
            // Cấu hình biểu đồ chartInventory
            chartInventory.Series.Clear();
            chartInventory.ChartAreas.Clear();
            chartInventory.Titles.Clear();

            // Thêm ChartArea cho biểu đồ
            ChartArea chartArea = new ChartArea("ChartArea1")
            {
                AxisX =
                {
                    Title = "Ngày",
                    LabelStyle = { Format = "dd/MM/yyyy" }  // Định dạng ngày trên trục X
                },
                AxisY =
                {
                    Title = "Số lượng thay đổi",
                    LabelStyle = { Format = "N0" } // Định dạng số nguyên trên trục Y
                }
            };
            chartInventory.ChartAreas.Add(chartArea);

            // Thêm tiêu đề cho biểu đồ
            chartInventory.Titles.Add("Báo cáo thay đổi số lượng tồn kho");

            // Tùy chỉnh thêm nếu cần
            chartInventory.BackColor = Color.White; // Màu nền của biểu đồ
            chartInventory.BorderlineColor = Color.Black; // Màu viền của biểu đồ
            chartInventory.BorderlineDashStyle = ChartDashStyle.Solid; // Kiểu đường viền của biểu đồ
        }

        private void dataGridViewItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3) // Cột Trạng thái
            {
                int currentQty = Convert.ToInt32(Inventory_DGV.Rows[e.RowIndex].Cells[1].Value);
                int safetyQty = Convert.ToInt32(Inventory_DGV.Rows[e.RowIndex].Cells[2].Value);
                if (currentQty < safetyQty)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void LoadInventoryReport()
        {
            try
            {
                // Lấy ngày hiện tại (hoặc bạn có thể chọn ngày nào đó)
                DateTime today = DateTime.Now.Date;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Truy vấn lấy dữ liệu từ InventoryLogs theo ChangeDate
                    string query = @"
                            SELECT 
                                CAST(L.ChangeDate AS DATE) AS LogDate, 
                                SUM(CASE WHEN L.Type = 'Nhập' THEN L.ChangeAmount ELSE -L.ChangeAmount END) AS StockChange
                            FROM InventoryLogs L
                            WHERE L.ChangeDate >= @StartDate AND L.ChangeDate <= @EndDate
                            GROUP BY CAST(L.ChangeDate AS DATE)
                            ORDER BY LogDate";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StartDate", today.AddDays(-30)); // 30 ngày qua
                    cmd.Parameters.AddWithValue("@EndDate", today);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa dữ liệu cũ trên Chart trước khi thêm mới
                    chartInventory.Series.Clear();
                    chartInventory.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Định dạng ngày

                    // Tạo Series cho biểu đồ
                    var series = new Series("Stock Changes")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 3
                    };

                    // Đọc dữ liệu và thêm vào biểu đồ
                    while (reader.Read())
                    {
                        DateTime logDate = Convert.ToDateTime(reader["LogDate"]);
                        int stockChange = Convert.ToInt32(reader["StockChange"]);

                        series.Points.AddXY(logDate, stockChange);
                    }

                    // Thêm series vào Chart
                    chartInventory.Series.Add(series);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }


        private void LoadInventoryLogs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT LogID, ItemID, ChangeAmount, ChangeDate, Type FROM InventoryLogs";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa các dòng cũ trước khi thêm mới
                    inventoryLog_DGV.Rows.Clear();

                    while (reader.Read())
                    {
                        inventoryLog_DGV.Rows.Add(
                            reader["ItemID"],
                            reader["ChangeAmount"],
                            Convert.ToDateTime(reader["ChangeDate"]).ToString("yyyy-MM-dd HH:mm:ss"),
                            reader["Type"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu InventoryLogs: " + ex.Message);
            }
        }

        private void LoadInventory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Truy vấn dữ liệu Inventory và tính toán UpdatedStock
                    string query = @"
                SELECT 
                    I.ItemID, 
                    I.ItemName, 
                    ISNULL(I.CurrentStock + SUM(CASE WHEN L.Type = 'Nhập' THEN L.ChangeAmount ELSE -L.ChangeAmount END), I.CurrentStock) AS UpdatedStock, 
                    I.SafeThreshold
                FROM Inventory I
                LEFT JOIN InventoryLogs L ON I.ItemID = L.ItemID
                GROUP BY I.ItemID, I.ItemName, I.CurrentStock, I.SafeThreshold";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa các dòng cũ trước khi thêm mới
                    Inventory_DGV.Rows.Clear();

                    while (reader.Read())
                    {
                        int updatedStock = Convert.ToInt32(reader["UpdatedStock"]);
                        int safeThreshold = Convert.ToInt32(reader["SafeThreshold"]);
                        string itemName = reader["ItemName"].ToString();

                        // Thêm dữ liệu vào DataGridView
                        int rowIndex = Inventory_DGV.Rows.Add(
                            reader["ItemID"],
                            itemName,
                            updatedStock,
                            safeThreshold
                        );

                        // Kiểm tra nếu UpdatedStock < SafeThreshold và tô đỏ cột ItemName
                        if (updatedStock < safeThreshold)
                        {
                            Inventory_DGV.Rows[rowIndex].Cells["ItemName"].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            // Nếu không dưới ngưỡng an toàn, để màu bình thường
                            Inventory_DGV.Rows[rowIndex].Cells["ItemName"].Style.ForeColor = Color.Black;
                        }
                    }

                    // Tự động điều chỉnh kích thước cột
                    Inventory_DGV.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Inventory: " + ex.Message);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Nhập");
            cmbType.Items.Add("Xuất");
            cmbType.SelectedIndex = 0; // Chọn giá trị mặc định là "Nhập"

            InitializeChart();
            LoadInventoryReport();
            LoadInventoryLogs();
        }

        private void btnAddNewitem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void inventoryLog_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int itemID = Convert.ToInt32(txtItemID.Text);
                int changeAmount = Convert.ToInt32(txtChangeAmount.Text);
                string type = cmbType.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Bắt đầu giao dịch để đảm bảo tính toàn vẹn dữ liệu
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Thêm bản ghi vào InventoryLogs
                            string queryLog = "INSERT INTO InventoryLogs (ItemID, ChangeAmount, Type) VALUES (@ItemID, @ChangeAmount, @Type)";
                            SqlCommand cmdLog = new SqlCommand(queryLog, conn, transaction);
                            cmdLog.Parameters.AddWithValue("@ItemID", itemID);
                            cmdLog.Parameters.AddWithValue("@ChangeAmount", changeAmount);
                            cmdLog.Parameters.AddWithValue("@Type", type);

                            int rowsAffected = cmdLog.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Xác định hướng điều chỉnh tồn kho
                                int adjustment = (type == "Nhập") ? changeAmount : -changeAmount;

                                // Cập nhật CurrentStock trong bảng Inventory
                                string queryUpdateStock = "UPDATE Inventory SET CurrentStock = CurrentStock + @Adjustment WHERE ItemID = @ItemID";
                                SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, conn, transaction);
                                cmdUpdateStock.Parameters.AddWithValue("@Adjustment", adjustment);
                                cmdUpdateStock.Parameters.AddWithValue("@ItemID", itemID);

                                int updateRows = cmdUpdateStock.ExecuteNonQuery();

                                if (updateRows > 0)
                                {
                                    // Commit giao dịch nếu cả hai thao tác đều thành công
                                    transaction.Commit();
                                    MessageBox.Show("Thêm log và cập nhật tồn kho thành công!");
                                    LoadInventoryLogs(); // Tải lại dữ liệu để cập nhật DataGridView
                                }
                                else
                                {
                                    throw new Exception("Không thể cập nhật tồn kho.");
                                }
                            }
                            else
                            {
                                throw new Exception("Không thể thêm log. Vui lòng thử lại.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback giao dịch nếu có lỗi
                            transaction.Rollback();
                            MessageBox.Show("Lỗi khi thực hiện thao tác: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm log: " + ex.Message);
            }
        }

        private void Inventory_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewitem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text.Trim();
                int currentStock = Convert.ToInt32(CurrentStock_txt.Text);
                int safeThreshold = Convert.ToInt32(SafeThreshold_txt.Text);

                if (string.IsNullOrEmpty(itemName) || currentStock < 0 || safeThreshold < 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Inventory (ItemName, CurrentStock, SafeThreshold) VALUES (@ItemName, @CurrentStock, @SafeThreshold)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@CurrentStock", currentStock);
                    cmd.Parameters.AddWithValue("@SafeThreshold", safeThreshold);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm hàng hóa mới thành công!");
                        LoadInventory(); // Tải lại dữ liệu sau khi thêm
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm hàng hóa. Vui lòng thử lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hàng hóa: " + ex.Message);
            }
        }

        private void searchCurrent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtItemName.Text.Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ItemID, ItemName, CurrentStock, SafeThreshold FROM Inventory WHERE ItemName LIKE @SearchKeyword";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Kiểm tra xem DataTable có dữ liệu hay không
                    if (dt.Rows.Count > 0)
                    {
                        // Hiển thị dữ liệu trong DataGridView
                        Inventory_DGV.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void LoadInventoryData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                            SELECT i.ItemID, i.ItemName, i.CurrentStock, i.SafeThreshold
                            FROM Inventory i";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Inventory_DGV.DataSource = dt; // Cập nhật DataGridView với dữ liệu mới

                    // Kiểm tra điều kiện CurrentStock < SafeThreshold và thay đổi màu sắc của ô nếu cần
                    foreach (DataGridViewRow row in Inventory_DGV.Rows)
                    {
                        int currentStock = Convert.ToInt32(row.Cells["CurrentStock"].Value);
                        int safeThreshold = Convert.ToInt32(row.Cells["SafeThreshold"].Value);

                        // Kiểm tra nếu tồn kho nhỏ hơn ngưỡng an toàn
                        if (currentStock < safeThreshold)
                        {
                            // Tô màu đỏ cho tên hàng hóa nếu tồn kho nhỏ hơn ngưỡng an toàn
                            row.Cells["ItemName"].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            // Nếu không nhỏ hơn ngưỡng an toàn, giữ màu mặc định
                            row.Cells["ItemName"].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại dữ liệu: " + ex.Message);
            }
        }
        private void Reload_btn_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }
    }
}

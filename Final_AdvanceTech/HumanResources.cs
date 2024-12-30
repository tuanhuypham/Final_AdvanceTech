using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_AdvanceTech
{
    public partial class HumanResources : Form
    {
        private string connectionString = "Data Source=LAPTOP-HK44U3IK;Initial Catalog=Resaurant_system;Integrated Security=True;TrustServerCertificate=True;";

        public HumanResources()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadSchedules()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT EmployeeID, WorkDate, Shift FROM Schedules";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa tất cả dữ liệu cũ trong DataGridView trước khi thêm mới
                    schedulesDataGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        // Thêm dữ liệu vào DataGridView
                        int employeeId = reader.GetInt32(0);
                        DateTime workDate = reader.GetDateTime(1);
                        string shift = reader.GetString(2);

                        // Chèn một dòng mới vào DataGridView
                        schedulesDataGridView.Rows.Add(employeeId, workDate.ToString("yyyy-MM-dd"), shift);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch làm việc: " + ex.Message);
            }
        }

        private void LoadPerformanceData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT p.EmployeeID, p.Month, p.Year, p.Score, p.Comments " +
                                   "FROM Performance p " +
                                   "INNER JOIN Employees e ON p.EmployeeID = e.EmployeeID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa các dữ liệu cũ trong DataGridView trước khi thêm dữ liệu mới
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        // Lấy dữ liệu từ kết quả truy vấn
                        int employeeID = reader.GetInt32(0);
                        int month = reader.GetInt32(1);
                        int year = reader.GetInt32(2);
                        decimal score = reader.GetDecimal(3);
                        string comments = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                        // Thêm dữ liệu vào DataGridView
                        dataGridView1.Rows.Add(employeeID, month, year, score, comments);
                        dataGridViewEmployees.Rows.Add(employeeID, month, year, score, comments);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hiệu suất: " + ex.Message);
            }
        }

        private void HumanResources_Load(object sender, EventArgs e)
        {
            // Thêm giá trị "Ca sáng" và "Ca tối" vào ComboBox
            comboBoxShift.Items.Add("Ca sáng");
            comboBoxShift.Items.Add("Ca tối");

            // Đặt giá trị mặc định (nếu cần)
            comboBoxShift.SelectedIndex = 0;  // Chọn "Ca sáng" làm mặc định

            LoadSchedules();
            LoadPerformanceData();
        }

        private void btnAddTimeToWork_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các điều khiển người dùng nhập
                int employeeID = Convert.ToInt32(employId_txt.Text);  // Lấy EmployeeID từ TextBox
                DateTime workDate = dateTimePickerWorkDate.Value;  // Lấy WorkDate từ DateTimePicker
                string shift = comboBoxShift.SelectedItem.ToString();  // Lấy Shift từ ComboBox

                // Kiểm tra nếu có trường nào để trống
                if (string.IsNullOrWhiteSpace(employId_txt.Text) ||
                    string.IsNullOrWhiteSpace(shift))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Tạo câu truy vấn SQL để thêm lịch làm việc
                string query = "INSERT INTO Schedules (EmployeeID, WorkDate, Shift) " +
                               "VALUES (@EmployeeID, @WorkDate, @Shift)";

                // Kết nối với cơ sở dữ liệu và thực hiện truy vấn
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    cmd.Parameters.AddWithValue("@WorkDate", workDate);
                    cmd.Parameters.AddWithValue("@Shift", shift);

                    // Thực thi câu truy vấn
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Kiểm tra nếu câu lệnh thành công
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm lịch làm việc thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm lịch làm việc.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void schedulesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowRating_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy các giá trị từ các TextBox
                int selectedEmployeeID = Convert.ToInt32(employeeID_txt.Text);  // Lấy EmployeeID từ TextBox
                int selectedMonth = Convert.ToInt32(Month_Performent.Text);  // Lấy Month từ TextBox
                int selectedYear = Convert.ToInt32(Year_Performent.Text);  // Lấy Year từ TextBox

                // Xóa các dòng cũ trong DataGridView
                dataGridView1.Rows.Clear();

                // Tạo câu truy vấn SQL với các điều kiện lọc
                string query = "SELECT p.EmployeeID, p.Month, p.Year, p.Score, p.Comments, e.Position " +
                               "FROM Performance p " +
                               "INNER JOIN Employees e ON p.EmployeeID = e.EmployeeID " +
                               "WHERE p.EmployeeID = @EmployeeID AND p.Month = @Month AND p.Year = @Year";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);
                    cmd.Parameters.AddWithValue("@Month", selectedMonth);
                    cmd.Parameters.AddWithValue("@Year", selectedYear);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Duyệt qua dữ liệu trả về từ truy vấn và thêm vào DataGridView
                    while (reader.Read())
                    {
                        // Lấy dữ liệu từ SqlDataReader
                        int employeeID = reader.GetInt32(0);
                        int month = reader.GetInt32(1);
                        int year = reader.GetInt32(2);
                        decimal score = reader.GetDecimal(3);
                        string comments = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                        string position = reader.GetString(5);

                        // Thêm dữ liệu vào DataGridView
                        dataGridView1.Rows.Add(employeeID, month, year, score, comments, position);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin đánh giá: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ textbox
                int employeeID = Convert.ToInt32(employeesID_txt.Text);
                int month = Convert.ToInt32(monthPerforment_txt.Text);
                int year = Convert.ToInt32(yearPerforment_txt.Text);
                decimal score = Convert.ToDecimal(txtScore.Text);
                string comments = commentPerforment_txt.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Cập nhật dữ liệu trong bảng Performance
                    string query = "UPDATE Performance " +
                                   "SET Score = @Score, Comments = @Comments " +
                                   "WHERE EmployeeID = @EmployeeID AND Month = @Month AND Year = @Year";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Score", score);
                    cmd.Parameters.AddWithValue("@Comments", comments);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin đánh giá đã được cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để cập nhật.");
                    }
                }

                // Tải lại dữ liệu lên DataGridView
                LoadPerformanceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ textbox
                int employeeID = Convert.ToInt32(employeesID_txt.Text);
                int month = Convert.ToInt32(monthPerforment_txt.Text);
                int year = Convert.ToInt32(yearPerforment_txt.Text);
                decimal score = Convert.ToDecimal(txtScore.Text);
                string comments = commentPerforment_txt.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Thêm dữ liệu vào bảng Performance
                    string query = "INSERT INTO Performance (EmployeeID, Month, Year, Score, Comments) " +
                                   "VALUES (@EmployeeID, @Month, @Year, @Score, @Comments)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Score", score);
                    cmd.Parameters.AddWithValue("@Comments", comments);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đánh giá đã được thêm thành công!");
                }

                // Sau khi thêm, tải lại dữ liệu lên DataGridView
                LoadPerformanceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không chọn tiêu đề cột
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị thông tin vào các TextBox
                monthPerforment_txt.Text = row.Cells["Month"].Value.ToString();
                yearPerforment_txt.Text = row.Cells["Year"].Value.ToString();
                employeeID_txt.Text = row.Cells["EmployeeID"].Value.ToString();
                commentPerforment_txt.Text = row.Cells["Comments"].Value.ToString();
                txtScore.Text = row.Cells["Score"].Value.ToString();
            }
        }
    }
}

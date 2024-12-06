using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Final_AdvanceTech
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void InitializeBarChart()
        {
            // Cấu hình biểu đồ Bar Chart
            chartBar.Series.Clear();
            chartBar.ChartAreas.Clear();
            chartBar.Titles.Clear();

            // Thêm ChartArea
            ChartArea barArea = new ChartArea("BarChartArea")
            {
                AxisX = { Title = "Tháng", Interval = 1 },
                AxisY = { Title = "Số lượng" }
            };
            chartBar.ChartAreas.Add(barArea);

            // Thêm Series
            Series barSeries = new Series
            {
                Name = "Số lượng nhập/xuất",
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true // Hiển thị giá trị trên cột
            };

            // Thêm dữ liệu
            barSeries.Points.AddXY("Tháng 1", 50);
            barSeries.Points.AddXY("Tháng 2", 70);
            barSeries.Points.AddXY("Tháng 3", 40);

            // Thiết lập màu cho từng cột (tuỳ chọn)
            barSeries.Points[0].Color = Color.Red;
            barSeries.Points[1].Color = Color.Green;
            barSeries.Points[2].Color = Color.Blue;

            chartBar.Series.Add(barSeries);

            // Thêm tiêu đề
            chartBar.Titles.Add("Biểu đồ số lượng nhập/xuất hàng hóa");

            // Thêm Legend (tuỳ chọn)
            chartBar.Legends.Clear();
            chartBar.Legends.Add(new Legend("Legend1"));
        }


        private void InitializeCharts()
        {
            // Cấu hình biểu đồ Bar Chart
            chartBar.Series.Clear();
            chartBar.ChartAreas.Clear();

            ChartArea barArea = new ChartArea("BarChartArea");
            chartBar.ChartAreas.Add(barArea);

            Series barSeries = new Series
            {
                Name = "Số lượng nhập/xuất",
                ChartType = SeriesChartType.Bar
            };

            barSeries.Points.AddXY("Tháng 1", 50);
            barSeries.Points.AddXY("Tháng 2", 70);
            barSeries.Points.AddXY("Tháng 3", 40);

            chartBar.Series.Add(barSeries);

            // Cấu hình biểu đồ Line Chart
            chartLine.Series.Clear();
            chartLine.ChartAreas.Clear();

            ChartArea lineArea = new ChartArea("LineChartArea");
            chartLine.ChartAreas.Add(lineArea);

            Series lineSeries = new Series
            {
                Name = "Xu hướng hàng tồn",
                ChartType = SeriesChartType.Line
            };

            lineSeries.Points.AddXY("Tháng 1", 200);
            lineSeries.Points.AddXY("Tháng 2", 150);
            lineSeries.Points.AddXY("Tháng 3", 180);

            chartLine.Series.Add(lineSeries);
        }

        private void UpdateBarChart(string[] labels, int[] values)
        {
            chartBar.Series[0].Points.Clear();
            for (int i = 0; i < labels.Length; i++)
            {
                chartBar.Series[0].Points.AddXY(labels[i], values[i]);
            }
        }

        private void UpdateLineChart(string[] labels, int[] values)
        {
            chartLine.Series[0].Points.Clear();
            for (int i = 0; i < labels.Length; i++)
            {
                chartLine.Series[0].Points.AddXY(labels[i], values[i]);
            }
        }

        private void dataGridViewItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3) // Cột Trạng thái
            {
                int currentQty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                int safetyQty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
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


        private void Inventory_Load(object sender, EventArgs e)
        {
            InitializeBarChart();
            InitializeCharts();
        }

        private void ResetInputFields()
        {
            // Kiểm tra và đặt lại TextBox
            if (txtItemName != null)
                txtItemName.Text = string.Empty;

            // Kiểm tra và đặt lại NumericUpDown (Số lượng hiện tại)
            if (nudCurrentQuantity != null)
            {
                nudCurrentQuantity.Value = nudCurrentQuantity.Minimum; // Hoặc đặt về 0
            }

            // Kiểm tra và đặt lại NumericUpDown (Ngưỡng an toàn)
            if (nudSafetyThreshold != null)
            {
                nudSafetyThreshold.Value = nudSafetyThreshold.Minimum; // Hoặc đặt về 0
            }

            // Đưa con trỏ chuột về TextBox đầu tiên
            if (txtItemName != null)
                txtItemName.Focus();
        }

        private void btnAddNewitem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            int currentQty = (int)nudCurrentQuantity.Value;
            int safetyQty = (int)nudSafetyThreshold.Value;

            dataGridView1.Rows.Add(itemName, currentQty, safetyQty, currentQty < safetyQty ? "Thiếu" : "Đủ");
            MessageBox.Show("Thêm hàng hóa thành công!", "Thông báo");
            ResetInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = txtItemName.Text;
                row.Cells[1].Value = nudCurrentQuantity.Value;
                row.Cells[2].Value = nudSafetyThreshold.Value;
                row.Cells[3].Value = (int)nudCurrentQuantity.Value < (int)nudSafetyThreshold.Value ? "Thiếu" : "Đủ";

                MessageBox.Show("Cập nhật hàng hóa thành công!", "Thông báo");
                ResetInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Lỗi");
            }
        }
    }
}

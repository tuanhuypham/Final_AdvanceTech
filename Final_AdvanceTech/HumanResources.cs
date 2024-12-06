using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_AdvanceTech
{
    public partial class HumanResources : Form
    {
        public HumanResources()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào một dòng hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin nhân viên từ dòng được chọn
                DataGridViewRow selectedRow = dataGridViewEmployees.Rows[e.RowIndex];

                // Hiển thị thông tin vào các TextBox
                textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                textBoxPosition.Text = selectedRow.Cells["Position"].Value.ToString();
                progressBarPerformance.Value = Convert.ToInt32(selectedRow.Cells["Performance"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một nhân viên trong DataGridView
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn trong DataGridView
                DataGridViewRow selectedRow = dataGridViewEmployees.SelectedRows[0];

                // Cập nhật thông tin nhân viên vào DataGridView
                selectedRow.Cells["Performance"].Value = progressBarPerformance.Value; // Cập nhật hiệu suất

                // Cập nhật lại thông tin của TextBox
                textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                textBoxPosition.Text = selectedRow.Cells["Position"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng chỉnh sửa thông tin hiệu suất trong ProgressBar
            progressBarPerformance.Enabled = true; // Cho phép thay đổi hiệu suất
            btnUpdate.Enabled = true; // Kích hoạt nút cập nhật
        }
    }
}

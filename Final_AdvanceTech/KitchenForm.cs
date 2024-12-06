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
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewOrders.SelectedRows[0];
                row.Cells["Status"].Value = "Chuẩn bị";  // Cập nhật trạng thái
                ShowNotification("Món ăn đã được bắt đầu chuẩn bị.");
            }
            else
            {
                ShowNotification("Vui lòng chọn một món ăn để cập nhật trạng thái.");
            }
        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewOrders.SelectedRows[0];
                row.Cells["Status"].Value = "Đang nấu";  // Cập nhật trạng thái
                ShowNotification("Món ăn đang được chế biến.");
            }
            else
            {
                ShowNotification("Vui lòng chọn một món ăn để cập nhật trạng thái.");
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewOrders.SelectedRows[0];
                row.Cells["Status"].Value = "Hoàn thành";  // Cập nhật trạng thái
                ShowNotification("Món ăn đã hoàn thành, thông báo cho phục vụ.");
            }
            else
            {
                ShowNotification("Vui lòng chọn một món ăn để cập nhật trạng thái.");
            }
        }

        // Hiển thị thông báo
        private void ShowNotification(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using Final_AdvanceTech.Services;
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
        private OrderService _orderService = new OrderService();
        private OrderDetailService _orderDetailService = new OrderDetailService();
        private TablesService _tablesService = new TablesService();
        private MenuService _menuService = new MenuService();
        private BindingSource bindingSource = new BindingSource();
        private int _tableNumber;
        public KitchenForm(int tablenumber)
        {
            InitializeComponent();
            _tableNumber = tablenumber;

            int initOrderDetail = _orderService.GetOrderByTableId(_tableNumber)?.OrderID ?? 0;
            bindingSource.DataSource = _orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);

            dataGridViewOrders.Columns.Add("dishName", "Dish Name");
            dataGridViewOrders.Columns.Add("dishPrice", "Dish Price");
            dataGridViewOrders.Columns.Add("dishCateGory", "CateGory");
            dataGridViewOrders.Columns.Add("orderStatus", "Order Status");
            dataGridViewOrders.Columns.Add("tableStatus", "Table Status");
            dataGridViewOrders.DataSource = bindingSource;
            dataGridViewOrders.Columns["MenuItemID"].Visible = false;
            dataGridViewOrders.Columns["OrderID"].Visible = false;
            dataGridViewOrders.Columns["OrderDetailID"].Visible = false;
            dataGridViewOrders.CellFormatting += dataGridViewOrders_CellFormatting;
        }

        private void dataGridViewOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu là dòng hợp lệ
            {
                if (
                    dataGridViewOrders.Rows[e.RowIndex].Cells["MenuItemID"].Value != null &&
                    dataGridViewOrders.Rows[e.RowIndex].Cells["OrderID"].Value!=null
                    )
                {
                    var dishid = (int)dataGridViewOrders.Rows[e.RowIndex].Cells["MenuItemID"].Value;
                    int orderid = (int)dataGridViewOrders.Rows[e.RowIndex].Cells["OrderID"].Value;
                    var dish = _menuService.GetMenuById(dishid);
                    var order = _orderService.GetOrderById(orderid);
                    var table = _tablesService.GetTableByTableNumber(order.TableID);
                    dataGridViewOrders.Rows[e.RowIndex].Cells["dishName"].Value = dish.ItemName;
                    dataGridViewOrders.Rows[e.RowIndex].Cells["dishPrice"].Value = dish.Price;
                    dataGridViewOrders.Rows[e.RowIndex].Cells["dishCateGory"].Value = dish.Category;
                    dataGridViewOrders.Rows[e.RowIndex].Cells["orderStatus"].Value = order.Status;
                    dataGridViewOrders.Rows[e.RowIndex].Cells["tableStatus"].Value = table.TableStatus;
                    dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
        }


        private void btnPrepare_Click(object sender, EventArgs e)
        {
            _tablesService.updateTableStatus(_tableNumber, "Chuẩn bị");
            int initOrderDetail = _orderService.GetOrderByTableId(_tableNumber)?.OrderID ?? 0;
            bindingSource.DataSource = _orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            _tablesService.updateTableStatus(_tableNumber, "Đang chế biến");
            int initOrderDetail = _orderService.GetOrderByTableId(_tableNumber)?.OrderID ?? 0;
            bindingSource.DataSource = _orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            _tablesService.updateTableStatus(_tableNumber, "Hoàn Thành");
            int initOrderDetail = _orderService.GetOrderByTableId(_tableNumber)?.OrderID ?? 0;
            bindingSource.DataSource = _orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
        }

        // Hiển thị thông báo
        private void ShowNotification(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

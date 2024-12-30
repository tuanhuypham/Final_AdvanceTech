using Final_AdvanceTech.Models;
using Final_AdvanceTech.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_AdvanceTech.Forms.FTableServices
{
    public partial class SelectDishForm : Form
    {
        private MenuService menuService = new MenuService();
        private BindingSource bindingSource;
        private int _tableID;
        private int _orderID;
        public List<OrderDetail> SelectedOrderDetails = new List<OrderDetail>();


        public SelectDishForm()
        {
            InitializeComponent();
            
        }

        public SelectDishForm(int TableID,int orderid)
        {
            InitializeComponent();
            _tableID = TableID;
            _orderID = orderid;
            ListMenuData.DataSource = menuService.GetMenus();
            ListMenuData.DisplayMember = "DisplayMenu";
            
            SelectedDisesGridView.Columns.Add("dishName", "Name");
            SelectedDisesGridView.Columns.Add("dishPrice", "Price");
            SelectedDisesGridView.Columns.Add("dishCateGory", "CateGory");
            //SelectedDisesGridView.Columns.Add("test", "test");
            bindingSource = new BindingSource();
            bindingSource.DataSource = SelectedOrderDetails;
            SelectedDisesGridView.DataSource = bindingSource;
            SelectedDisesGridView.Columns["MenuItemID"].Visible = false;
            SelectedDisesGridView.Columns["OrderDetailID"].Visible = false;
            SelectedDisesGridView.CellFormatting += SelectedDisesGridView_CellFormatting;
        }

        private void SelectedDisesGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu là dòng hợp lệ
            {
                if (SelectedOrderDetails.Count > 0)
                {
                    // Lấy giá trị từ cột "Price" ở dòng hiện tại
                    if (SelectedDisesGridView.Rows[e.RowIndex].Cells["MenuItemID"].Value != null)
                    {
                        int rowMenuItemID = (int)SelectedDisesGridView.Rows[e.RowIndex].Cells["MenuItemID"].Value;
                        var menuId = rowMenuItemID;
                        Menus menu = menuService.GetMenuById(menuId);
                        SelectedDisesGridView.Rows[e.RowIndex].Cells["dishName"].Value = menu.ItemName;
                        SelectedDisesGridView.Rows[e.RowIndex].Cells["dishPrice"].Value = menu.Price;
                        SelectedDisesGridView.Rows[e.RowIndex].Cells["dishCateGory"].Value = menu.Category;
                        //SelectedDisesGridView.Rows[e.RowIndex].Cells["test"].Value = _tableID;
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetCurrentDishes_Click(object sender, EventArgs e)
        {
            SelectedOrderDetails.Clear();
            SelectedDisesGridView.Rows.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int orderId = 0;

            if (_orderID == 0)
            {
                OrderService orderService = new OrderService();
                var order = new Orders
                {
                    TableID = _tableID,
                    OrderTime = DateTime.Now,
                    Status = "Chưa thanh toán"
                };
                orderId = orderService.CreateOrder(order);
                TablesService tableService = new TablesService();
                tableService.updateTableStatus(_tableID, "chờ phục vụ");
            }
            else
            {
                orderId = _orderID;
            }

            OrderDetailService orderDetailService = new OrderDetailService();
            if (orderId != 0)
            {
                foreach (var item in SelectedOrderDetails)
                {
                    item.OrderID = orderId;
                    item.note = "không ghi chú";
                }
                orderDetailService.addOrderDetails(SelectedOrderDetails);
            }
            Console.WriteLine("Order created");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedOrderDetails.Clear();
            SelectedDisesGridView.Rows.Clear();
            this.Close();
        }

        private void ListMenuDoubleClick(object sender, EventArgs e)
        {
            Menus selectedMenu = ListMenuData.SelectedItem as Menus;
            if (selectedMenu != null)
            {
                var item = SelectedOrderDetails.FirstOrDefault(o => o.MenuItemID == selectedMenu.MenuItemID);

                if (item == null)
                {
                    SelectedOrderDetails.Add(new OrderDetail
                    {
                        MenuItemID = selectedMenu.MenuItemID,
                        OrderID = 0,
                        quantity = 1,
                        note = "",
                    });
                }
                else
                {
                    item.quantity++;
                }
                bindingSource.ResetBindings(false);
            }
        }
    }
}

﻿using Final_AdvanceTech.Forms.FTableServices;
using Final_AdvanceTech.Models;
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
    

    public partial class TableService : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private OrderService orderService = new OrderService();
        private OrderDetailService orderDetailService = new OrderDetailService();
        private TablesService tablesService = new TablesService();
        public TableService()
        {
            InitializeComponents();
            LoadTableData();

            int initOrderDetail = orderService.GetOrderByTableId(1)?.OrderID ?? 0;
            bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);

            DataGridOrderDishes.Columns.Add("dishName", "Dish Name");
            DataGridOrderDishes.Columns.Add("dishPrice", "Dish Price");
            DataGridOrderDishes.Columns.Add("dishCateGory", "CateGory");
            DataGridOrderDishes.Columns.Add("orderStatus", "Order Status");
            DataGridOrderDishes.Columns.Add("tableStatus", "Table Status");
            DataGridOrderDishes.DataSource = bindingSource;
            DataGridOrderDishes.Columns["MenuItemID"].Visible = false;
            DataGridOrderDishes.Columns["OrderID"].Visible = false;
            DataGridOrderDishes.Columns["OrderDetailID"].Visible = false;
            DataGridOrderDishes.CellFormatting += DataGridOrderDishes_CellFormatting;
        }

        private void InitializeComponents()
        {
            // TreeView
            treeViewTables = new TreeView
            {
                Dock = DockStyle.Left,
                Width = 200
            };

            // Buttons
            btnAddOrder = new Button { Text = "Gọi món", Dock = DockStyle.Top };
            btnUpdateStatus = new Button { Text = "Nhà bếp", Dock = DockStyle.Top };
            btnShowNotifications = new Button { Text = "Thanh toán", Dock = DockStyle.Top };

            btnAddOrder.Click += btnAddOrder_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnShowNotifications.Click += BtnShowNotifications_Click;
            // DataGridView
            DataGridOrderDishes = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                ColumnCount = 2,
            };
            treeViewTables.AfterSelect += TreeViewTables_AfterSelect;

            // Layout
            var panelRight = new Panel
            {
                Dock = DockStyle.Right,
                Width = 150
            };
            panelRight.Controls.Add(btnShowNotifications);
            panelRight.Controls.Add(btnUpdateStatus);
            panelRight.Controls.Add(btnAddOrder);

            this.Controls.Add(treeViewTables);
            this.Controls.Add(DataGridOrderDishes);
            this.Controls.Add(panelRight);
            this.Text = "Quản lý phục vụ bàn";
            this.Width = 800;
            this.Height = 600;
        }

        private void BtnShowNotifications_Click(object sender, EventArgs e)
        {
            Payment_And_Billing payment_And_Billing = new Payment_And_Billing();
            payment_And_Billing.Show();
        }

        private void LoadTableData()
        {
            // Dữ liệu giả cho TreeView
            var area1 = new TreeNode("Khu vực Ban an");
            area1.Nodes.Add(new TreeNode("Bàn 1") { Tag = 1 });
            area1.Nodes.Add(new TreeNode("Bàn 2") { Tag = 2 });
            area1.Nodes.Add(new TreeNode("Bàn 3") { Tag = 3 });
            area1.Nodes.Add(new TreeNode("Bàn 4") { Tag = 4 });
            area1.Nodes.Add(new TreeNode("Bàn 5") { Tag = 5 });
            area1.Nodes.Add(new TreeNode("Bàn 6") { Tag = 6 });
            area1.Nodes.Add(new TreeNode("Bàn 7") { Tag = 7 });

            treeViewTables.Nodes.Add(area1);
        }

        private void DataGridOrderDishes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu là dòng hợp lệ
            {   
                MenuService menuService = new MenuService();
                // Lấy giá trị từ cột "Price" ở dòng hiện tại
                var dishid = (int)DataGridOrderDishes.Rows[e.RowIndex].Cells["MenuItemID"].Value;
                var orderid = (int)DataGridOrderDishes.Rows[e.RowIndex].Cells["OrderID"].Value;
                var dish = menuService.GetMenuById(dishid);
                var order = orderService.GetOrderById(orderid);
                var table = tablesService.GetTableByTableNumber(order.TableID);
                DataGridOrderDishes.Rows[e.RowIndex].Cells["dishName"].Value = dish.ItemName;
                DataGridOrderDishes.Rows[e.RowIndex].Cells["dishPrice"].Value = dish.Price;
                DataGridOrderDishes.Rows[e.RowIndex].Cells["dishCateGory"].Value = dish.Category;
                DataGridOrderDishes.Rows[e.RowIndex].Cells["orderStatus"].Value = order.Status;
                DataGridOrderDishes.Rows[e.RowIndex].Cells["tableStatus"].Value = table.TableStatus;
            }   
        }

        private void TreeViewTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                int tableId = (int)e.Node.Tag;
                LoadOrderDetails(tableId);
            }
        }

        private void LoadOrderDetails(int tableId)
        {
            // Dữ liệu giả cho DataGridView
            if (tableId == 1)
            {
                int initOrderDetail = orderService.GetOrderByTableId(1)?.OrderID ?? 0;
                bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.ResetBindings(false);
                this.Text = "Quản lý phục vụ bàn (Bàn "+1+")";
            }
            else if (tableId == 2)
            {
                int initOrderDetail = orderService.GetOrderByTableId(2)?.OrderID ?? 0;
                bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.ResetBindings(false);
                this.Text = "Quản lý phục vụ bàn (Bàn " + 2 + ")";
            }
            else if (tableId == 3)
            {
                int initOrderDetail = orderService.GetOrderByTableId(3)?.OrderID ?? 0;
                bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.ResetBindings(false);
                this.Text = "Quản lý phục vụ bàn (Bàn " + 3 + ")";
            }
            else if (tableId == 4)
            {
                int initOrderDetail = orderService.GetOrderByTableId(4)?.OrderID ?? 0;
                bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.ResetBindings(false);
                this.Text = "Quản lý phục vụ bàn (Bàn " + 4 + ")";
            }
            else if (tableId == 5)
            {
                int initOrderDetail = orderService.GetOrderByTableId(5)?.OrderID ?? 0;
                bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.ResetBindings(false);
                this.Text = "Quản lý phục vụ bàn (Bàn " + 5 + ")";
            }
            else if (tableId == 6)
            {
                int initOrderDetail = orderService.GetOrderByTableId(6)?.OrderID ?? 0;
                bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.ResetBindings(false);
                this.Text = "Quản lý phục vụ bàn (Bàn " + 6 + ")";
            }
            else if (tableId == 7)
            {
                int initOrderDetail = orderService.GetOrderByTableId(7)?.OrderID ?? 0;
                bindingSource.DataSource = orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.ResetBindings(false);
                this.Text = "Quản lý phục vụ bàn (Bàn " + 7 + ")";
            }
            else
            {
                bindingSource.DataSource = new List<OrderDetail>();
                bindingSource.ResetBindings(false);
            }
        }

        private void TableService_Load(object sender, EventArgs e)
        {

        }

        private void treeViewTables_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridViewOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {   
            int table = 0;
            if (treeViewTables.SelectedNode.Tag != null) {
                table = (int)treeViewTables.SelectedNode.Tag;
            }
            int initOrderDetail = orderService.GetOrderByTableId(table)?.OrderID ?? 0;
            //Console.WriteLine(initOrderDetail);
            using (SelectDishForm dialog = new SelectDishForm(table, initOrderDetail))
            {  
                // Mở dialog gọi món
                if (dialog.ShowDialog() == DialogResult.OK)
                { 

                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            int table = 0;
            if (treeViewTables.SelectedNode.Tag != null)
            {
                table = (int)treeViewTables.SelectedNode.Tag;
            }
            KitchenForm kitchenForm = new KitchenForm(table);
            kitchenForm.Text = "Nhà bếp (Bàn "+table+")";
            kitchenForm.Show();
        }

        private void btnShowNotifications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không có món ăn nào cần phục vụ!", "Thông báo");
        }
    }
}

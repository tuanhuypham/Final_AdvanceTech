using Final_AdvanceTech.Forms.FTableServices;
using Final_AdvanceTech.Models;
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
        private TreeView treeViewTable;
        private Button btn_AddOrder, btn_UpdateStatus, btn_ShowNotifications;

        private List<Orders> Orders = new List<Orders>();
        private List<OrderDishes> CurrentOrderDishes = new List<OrderDishes>();
        private List<Dishes> Dishes = new List<Dishes>();
        private BindingSource bindingSource = new BindingSource();
        public TableService()
        {
            InitializeComponents();
            LoadTableData();
        }

        public class OrderUI
        {
            public string Name { get; set; }  // Tên món ăn
            public decimal Price { get; set; }  // Giá của món ăn
            public string Note { get; set; }  // Ghi chú về món3 ăn
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
            btnUpdateStatus = new Button { Text = "Cập nhật trạng thái", Dock = DockStyle.Top };
            btnShowNotifications = new Button { Text = "Hiển thị thông báo", Dock = DockStyle.Top };

            btnAddOrder.Click += btnAddOrder_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnShowNotifications.Click += btnShowNotifications_Click;

            // DataGridView
            DataGridOrderDishes = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                ColumnCount = 2,
            };
            Orders = GetOrders();
            CurrentOrderDishes = GetOrderDishes();
            Dishes = GetVietnameseDishes();

            bindingSource.DataSource = CurrentOrderDishes;
            DataGridOrderDishes.DataSource = bindingSource;
            DataGridOrderDishes.Columns.Add("dishName", "Dish Name");
            DataGridOrderDishes.Columns.Add("dishPrice", "Dish Price");
            DataGridOrderDishes.CellFormatting += DataGridOrderDishes_CellFormatting;

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

        // Phương thức trả về danh sách món ăn
        public List<Dishes> GetVietnameseDishes()
        {
            return new List<Dishes>
            {
                new Dishes {dish_id=1, Name = "Phở bò", Price = 50000, Note = "Nước dùng thơm ngon, bò tái chín" },
                new Dishes {dish_id=2, Name = "Bún chả Hà Nội", Price = 45000, Note = "Chả nướng thơm lừng" },
                new Dishes {dish_id = 3,  Name = "Bún bò Huế", Price = 55000, Note = "Đậm đà hương vị Huế ,là  món tôi ăn thay cơm" },
                new Dishes {dish_id = 4,  Name = "Cơm tấm Sài Gòn", Price = 40000, Note = "Sườn nướng mềm, thơm" },
                new Dishes {dish_id = 5,  Name = "Cháo lòng", Price = 35000, Note = "Thơm ngon, ấm bụng" },
                new Dishes {dish_id = 6,  Name = "Nem rán (Chả giò)", Price = 30000, Note = "Giòn rụm, nhân thịt đậm vị" },
                new Dishes {dish_id = 7,  Name = "Nem cuốn (Gỏi cuốn)", Price = 25000, Note = "Tươi mát, chấm nước mắm ngon" },
                new Dishes {dish_id = 8,  Name = "Bánh xèo", Price = 35000, Note = "Vỏ giòn, nhân tôm thịt" },
                new Dishes {dish_id = 9,  Name = "Bánh cuốn", Price = 30000, Note = "Mềm mịn, nhân thịt nấm" },
                new Dishes {dish_id = 10,  Name = "Xôi gà", Price = 35000, Note = "Xôi mềm, gà thơm" },
                new Dishes {dish_id = 11,  Name = "Trà đá", Price = 5000, Note = "Giải khát truyền thống" },
                new Dishes {dish_id = 12,  Name = "Cà phê sữa đá", Price = 20000, Note = "Đậm vị cà phê Việt Nam" },
                new Dishes {dish_id = 13,  Name = "Nước mía", Price = 15000, Note = "Ngọt mát tự nhiên" },
                new Dishes {dish_id = 14,  Name = "Chè đậu xanh", Price = 25000, Note = "Ngọt thanh, giải nhiệt" },
                new Dishes {dish_id = 15,  Name = "Sinh tố dừa", Price = 30000, Note = "Thơm ngon, béo ngậy" }
            };
        }

        public List<Orders> GetOrders()
        {
            return new List<Orders>
            {
                new Orders{
                    order_id=1,
                    customer_id=1,
                    table_id=1,
                    order_time=new DateTime(),
                    payment_status="pending",
                    total_amount=0
                },
                new Orders{
                    order_id=2,
                    customer_id=2,
                    table_id=2,
                    order_time=new DateTime(),
                    payment_status="pending",
                    total_amount=0
                },
            };
        }

        public List<OrderDishes> GetOrderDishes()
        {
            return new List<OrderDishes>
            {
                new OrderDishes{
                    dish_id=5,
                    order_id=1,
                    note="sadsad",
                    quantity=1
                },
                new OrderDishes{
                    dish_id=6,
                    order_id=1,
                    note="sadsad",
                    quantity=1
                },
                new OrderDishes{
                    dish_id=7,
                    order_id=2,
                    note="sadsad",
                    quantity=1
                },
            };
        }

        public Dishes GetDishById(int id)
        {
            return Dishes.Where(d => d.dish_id == id).FirstOrDefault();
        }


        private void LoadTableData()
        {
            // Dữ liệu giả cho TreeView
            var area1 = new TreeNode("Khu vực 1");
            area1.Nodes.Add(new TreeNode("Bàn 1") { Tag = 1 });
            area1.Nodes.Add(new TreeNode("Bàn 2") { Tag = 2 });

            var area2 = new TreeNode("Khu vực 2");
            area2.Nodes.Add(new TreeNode("Bàn 3") { Tag = 3 });

            treeViewTables.Nodes.Add(area1);
            treeViewTables.Nodes.Add(area2);
        }

        private void DataGridOrderDishes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu là dòng hợp lệ
            {
                // Lấy giá trị từ cột "Price" ở dòng hiện tại
                var dishid = (int)DataGridOrderDishes.Rows[e.RowIndex].Cells["dish_id"].Value;
                var dish = GetDishById(dishid);
                DataGridOrderDishes.Rows[e.RowIndex].Cells["dishName"].Value = dish.Name; 
                DataGridOrderDishes.Rows[e.RowIndex].Cells["dishPrice"].Value = dish.Price; 
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
                var Orderid = Orders.Where(o => o.table_id == 1).Select(o=>o.order_id).ToList();
                var filteredOrders = CurrentOrderDishes.Where(o => Orderid.Contains(o.order_id)).ToList();
                bindingSource.DataSource = filteredOrders;
                bindingSource.ResetBindings(false);
            }
            else if (tableId == 2)
            {
                var Orderid = Orders.Where(o => o.table_id == 2).Select(o => o.order_id).ToList();
                var filteredOrders = CurrentOrderDishes.Where(o => Orderid.Contains(o.order_id)).ToList();
                bindingSource.DataSource = filteredOrders;
                bindingSource.ResetBindings(false);
            }
            else
            {
                bindingSource.DataSource = new List<OrderDishes>();
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
            //Lấy tất cả món an,ban hien tai
            List<Dishes> dishes = GetVietnameseDishes();

            int table = 0;
            if (treeViewTables.SelectedNode.Tag != null) {
                table = (int)treeViewTables.SelectedNode.Tag;
            }

            //Dua tất cả món an vao SelectDishForm
            using (SelectDishForm dialog = new SelectDishForm(dishes, table))
            {
                // Mở dialog gọi món
                if (dialog.ShowDialog() == DialogResult.OK)
                { 
                }
                else
                {
                    Orders.Add(new Orders
                    {
                        order_id = 5,
                        customer_id = 1,                            
                        table_id = table,
                        order_time = new DateTime(),
                        payment_status = "pending",
                        Order_status = "in progress",
                        total_amount = 0
                    });
                    var orderDishes = dialog.CurrentOrderDishes;
                    foreach (var orderDish in orderDishes)
                    {
                        orderDish.order_id = 5;
                    }
                    CurrentOrderDishes.AddRange(orderDishes);
                    bindingSource.ResetBindings(false);
                    LoadOrderDetails(table);
                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng cập nhật trạng thái đang được triển khai!", "Thông báo");
        }

        private void btnShowNotifications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không có món ăn nào cần phục vụ!", "Thông báo");
        }
    }
}

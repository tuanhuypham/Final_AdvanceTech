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
        private DataGridView dataGridViewOrderDetail;
        private Button btn_AddOrder, btn_UpdateStatus, btn_ShowNotifications;
        public TableService()
        {
            InitializeComponent();
            LoadTableData();
        }

        public class Dish
        {
            public string Name { get; set; }  // Tên món ăn
            public decimal Price { get; set; }  // Giá của món ăn
            public string Note { get; set; }  // Ghi chú về món ăn
        }

        // Phương thức trả về danh sách món ăn
        public List<Dish> GetVietnameseDishes()
        {
            return new List<Dish>
            {
                new Dish { Name = "Phở bò", Price = 50000, Note = "Nước dùng thơm ngon, bò tái chín" },
                new Dish { Name = "Bún chả Hà Nội", Price = 45000, Note = "Chả nướng thơm lừng" },
                new Dish { Name = "Bún bò Huế", Price = 55000, Note = "Đậm đà hương vị Huế" },
                new Dish { Name = "Cơm tấm Sài Gòn", Price = 40000, Note = "Sườn nướng mềm, thơm" },
                new Dish { Name = "Cháo lòng", Price = 35000, Note = "Thơm ngon, ấm bụng" },
                new Dish { Name = "Nem rán (Chả giò)", Price = 30000, Note = "Giòn rụm, nhân thịt đậm vị" },
                new Dish { Name = "Nem cuốn (Gỏi cuốn)", Price = 25000, Note = "Tươi mát, chấm nước mắm ngon" },
                new Dish { Name = "Bánh xèo", Price = 35000, Note = "Vỏ giòn, nhân tôm thịt" },
                new Dish { Name = "Bánh cuốn", Price = 30000, Note = "Mềm mịn, nhân thịt nấm" },
                new Dish { Name = "Xôi gà", Price = 35000, Note = "Xôi mềm, gà thơm" },
                new Dish { Name = "Trà đá", Price = 5000, Note = "Giải khát truyền thống" },
                new Dish { Name = "Cà phê sữa đá", Price = 20000, Note = "Đậm vị cà phê Việt Nam" },
                new Dish { Name = "Nước mía", Price = 15000, Note = "Ngọt mát tự nhiên" },
                new Dish { Name = "Chè đậu xanh", Price = 25000, Note = "Ngọt thanh, giải nhiệt" },
                new Dish { Name = "Sinh tố dừa", Price = 30000, Note = "Thơm ngon, béo ngậy" }
            };
        }



        private void InitializeComponents()
        {
            // TreeView
            treeViewTables = new TreeView
            {
                Dock = DockStyle.Left,
                Width = 200
            };
            treeViewTables.AfterSelect += TreeViewTables_AfterSelect;

            // DataGridView
            dataGridViewOrderDetails = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true
            };
            dataGridViewOrderDetails.Columns.Add("MenuItemID", "Mã món");
            dataGridViewOrderDetails.Columns.Add("ItemName", "Tên món");
            dataGridViewOrderDetails.Columns.Add("Quantity", "Số lượng");
            dataGridViewOrderDetails.Columns.Add("Notes", "Ghi chú");

            // Buttons
            btnAddOrder = new Button { Text = "Gọi món", Dock = DockStyle.Top };
            btnUpdateStatus = new Button { Text = "Cập nhật trạng thái", Dock = DockStyle.Top };
            btnShowNotifications = new Button { Text = "Hiển thị thông báo", Dock = DockStyle.Top };

            btnAddOrder.Click += btnAddOrder_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnShowNotifications.Click += btnShowNotifications_Click;

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
            this.Controls.Add(dataGridViewOrderDetails);
            this.Controls.Add(panelRight);
            this.Text = "Quản lý phục vụ bàn";
            this.Width = 800;
            this.Height = 600;
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
            dataGridViewOrderDetails.Rows.Clear();
            if (tableId == 1)
            {
                dataGridViewOrderDetails.Rows.Add(1, "Mì xào bò", 2, "Không cay");
                dataGridViewOrderDetails.Rows.Add(2, "Cơm gà", 1, "Thêm nước sốt");
            }
            else if (tableId == 2)
            {
                dataGridViewOrderDetails.Rows.Add(3, "Phở bò", 3, "Ít hành");
            }
            else
            {
                MessageBox.Show("Không có món nào cho bàn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Chức năng gọi món đang được triển khai!", "Thông báo");
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

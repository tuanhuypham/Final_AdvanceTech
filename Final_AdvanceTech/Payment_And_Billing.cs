using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Final_AdvanceTech.Services;
using System.Linq;
using Final_AdvanceTech.Models;

namespace Final_AdvanceTech
{
    

    public partial class Payment_And_Billing : Form
    {
        public class TableUi
        {
            public string name { set; get; }
            public int number { set; get; }
        }

        private TabControl tabControl;
        private TabPage tabPayment;
        private TabPage tabInvoiceHistory;
        private GroupBox groupBoxPaymentMethod;
        private RadioButton radioCash, radioCreditCard, radioEPayment;
        private TextBox txtUser_name, txtTotal_Amount;
        private ListView listViewOrderDetails;
        private Button btnGenerateInvoice, btnSendInvoice;
        private ListView listViewInvoiceHistory;
        private TextBox txtSearchInvoice;

        private List<TableUi> _tableList = new List<TableUi>();
        private BindingSource bindingSource = new BindingSource();
        private OrderService _orderService = new OrderService();
        private OrderDetailService _orderDetailService = new OrderDetailService();
        private MenuService _menuService = new MenuService();
        private BillsService _billsService = new BillsService();
        private TablesService _tablesService = new TablesService();
        private int _selectedOrderId = 0;
        public Payment_And_Billing()
        {   
            InitializeComponent();
            _tableList = new List<TableUi>
            {
                new TableUi { name = "Bàn 1", number = 1 },
                new TableUi { name = "Bàn 2", number = 2 },
                new TableUi { name = "Bàn 3", number = 3 },
                new TableUi { name = "Bàn 4", number = 4 },
                new TableUi { name = "Bàn 5", number = 5 },
                new TableUi { name = "Bàn 6", number = 6 },
                new TableUi { name = "Bàn 7", number = 7 },
            };
            listTablesBox.DataSource = _tableList;
            listTablesBox.DisplayMember = "name";
            listTablesBox.SelectedIndexChanged += ListTablesBox_SelectedIndexChanged;

            int initOrderDetail = _orderService.GetOrderByTableId(1)?.OrderID ?? 0;
            bindingSource.DataSource = _orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);

            OrderGridView.Columns.Add("dishName", "Dish Name");
            OrderGridView.Columns.Add("dishPrice", "Dish Price");
            OrderGridView.Columns.Add("dishCateGory", "CateGory");
            OrderGridView.Columns.Add("orderStatus", "Order Status");
            OrderGridView.Columns.Add("tableStatus", "Table Status");
            OrderGridView.DataSource = bindingSource;
            OrderGridView.Columns["MenuItemID"].Visible = false;
            OrderGridView.Columns["OrderID"].Visible = false;
            OrderGridView.Columns["OrderDetailID"].Visible = false;
            OrderGridView.CellFormatting += OrderGridView_CellFormatting;
            txtTotalAmount.Text = "0";

            listBox1.DataSource = _billsService.GetBills();
            listBox1.DisplayMember = "DisplayBills";

            tabPage2.Enter += tabPage2_Enter;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            listBox1.DataSource = _billsService.GetBills();
            listBox1.DisplayMember = "DisplayBills";
        }

        private void ListTablesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listTablesBox.SelectedIndex >= 0)
            {
                // Get the selected item (it can be an object, but usually it's a string)
                var table = listTablesBox.SelectedItem as TableUi;

                int initOrderDetail = _orderService.GetOrderByTableId(table.number)?.OrderID ?? 0;
                _selectedOrderId = initOrderDetail;
                var orderdetails = _orderDetailService.GetOrderDetailsByOrderId(initOrderDetail);
                bindingSource.DataSource = orderdetails;

                decimal totalPrice = 0;
                foreach (var item in orderdetails)
                {
                    totalPrice += _menuService.GetMenuById(item.MenuItemID).Price * item.quantity;
                }
                txtTotalAmount.Text = totalPrice.ToString();
                int rowcount = OrderGridView.RowCount-1;
                if (rowcount == 0)
                {
                    MessageBox.Show("Bàn trống");
                }
            }
        }

        private void OrderGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu là dòng hợp lệ
            {
                if (
                    OrderGridView.Rows[e.RowIndex].Cells["MenuItemID"].Value != null &&
                    OrderGridView.Rows[e.RowIndex].Cells["OrderID"].Value != null
                    )
                {
                    var dishid = (int)OrderGridView.Rows[e.RowIndex].Cells["MenuItemID"].Value;
                    int orderid = (int)OrderGridView.Rows[e.RowIndex].Cells["OrderID"].Value;
                    var dish = _menuService.GetMenuById(dishid);
                    var order = _orderService.GetOrderById(orderid);
                    var table = _tablesService.GetTableByTableNumber(order.TableID);
                    OrderGridView.Rows[e.RowIndex].Cells["dishName"].Value = dish.ItemName;
                    OrderGridView.Rows[e.RowIndex].Cells["dishPrice"].Value = dish.Price;
                    OrderGridView.Rows[e.RowIndex].Cells["dishCateGory"].Value = dish.Category;
                    OrderGridView.Rows[e.RowIndex].Cells["orderStatus"].Value = order.Status;
                    OrderGridView.Rows[e.RowIndex].Cells["tableStatus"].Value = table.TableStatus;
                    OrderGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
        }

        private void InitializeComponents()
        {
            // TabControl
            tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            // Tab "Thanh toán mới"
            tabPayment = new TabPage("Thanh toán mới");
            groupBoxPaymentMethod = new GroupBox
            {
                Text = "Phương thức thanh toán",
                Dock = DockStyle.Top
            };

            radioCash = new RadioButton { Text = "Tiền mặt", Dock = DockStyle.Left };
            radioCreditCard = new RadioButton { Text = "Thẻ tín dụng", Dock = DockStyle.Left };
            radioEPayment = new RadioButton { Text = "Thanh toán điện tử", Dock = DockStyle.Left };
            groupBoxPaymentMethod.Controls.Add(radioCash);
            groupBoxPaymentMethod.Controls.Add(radioCreditCard);
            groupBoxPaymentMethod.Controls.Add(radioEPayment);

            // TextBox cho tên người dùng (với placeholder thủ công)
            txtUser_name = new TextBox
            {
                Dock = DockStyle.Top,
                ForeColor = Color.Gray,  // Màu chữ placeholder
                Text = "Nhập tên người dùng"
            };
            txtUser_name.Enter += TxtUser_name_Enter;
            txtUser_name.Leave += TxtUser_name_Leave;

            // TextBox cho tổng tiền
            txtTotal_Amount = new TextBox
            {
                Dock = DockStyle.Top
            };

            // ListView để biết chi tiết đơn hàng (hiển thị các món ăn đã đặt)
            listViewOrderDetails = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details
            };
            listViewOrderDetails.Columns.Add("Mã món", 100);
            listViewOrderDetails.Columns.Add("Tên món", 200);
            listViewOrderDetails.Columns.Add("Số lượng", 100);
            listViewOrderDetails.Columns.Add("Giá", 100);

            // Nút để tạo hóa đơn
            btnGenerateInvoice = new Button { Text = "Lập hóa đơn", Dock = DockStyle.Top };
            btnGenerateInvoice.Click += btnAddBillPayment_Click;

            // Nút show QRcode
            btnSendInvoice = new Button { Text = "Gửi hóa đơn", Dock = DockStyle.Top };
            btnSendInvoice.Click += BtnQRcode_Click;

            // Thêm tất cả các thành phần vào tabPayment
            tabPayment.Controls.Add(groupBoxPaymentMethod);
            tabPayment.Controls.Add(txtUser_name);
            tabPayment.Controls.Add(txtTotal_Amount);
            tabPayment.Controls.Add(listViewOrderDetails);
            tabPayment.Controls.Add(btnGenerateInvoice);
            tabPayment.Controls.Add(btnSendInvoice);

            // Tab "Quản lý hóa đơn"
            tabInvoiceHistory = new TabPage("Quản lý hóa đơn");

            // ListView để hiển thị các hóa đơn cũ
            listViewInvoiceHistory = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details
            };
            listViewInvoiceHistory.Columns.Add("Mã hóa đơn", 100);
            listViewInvoiceHistory.Columns.Add("Ngày thanh toán", 150);
            listViewInvoiceHistory.Columns.Add("Tổng tiền", 100);

            // Hộp tìm kiếm hóa đơn
            txtSearchInvoice = new TextBox
            {
                Dock = DockStyle.Top,
            };

            // Thêm hộp tìm kiếm và listView vào tabInvoiceHistory
            tabInvoiceHistory.Controls.Add(txtSearchInvoice);
            tabInvoiceHistory.Controls.Add(listViewInvoiceHistory);

            // Thêm tab vào TabControl
            tabControl.TabPages.Add(tabPayment);
            tabControl.TabPages.Add(tabInvoiceHistory);

            // Thêm TabControl vào Form
            this.Controls.Add(tabControl);

            this.Text = "Quản lý thanh toán và hóa đơn";
            this.Width = 800;
            this.Height = 600;
        }

        private void TxtUser_name_Leave(object sender, EventArgs e)
        {
            // Khi rời khỏi TextBox, nếu không có dữ liệu thì đặt lại placeholder
            if (string.IsNullOrWhiteSpace(txtUser_name.Text))
            {
                txtUser_name.ForeColor = Color.Gray;
                txtUser_name.Text = "Nhập tên người dùng";
            }
        }

        private void TxtUser_name_Enter(object sender, EventArgs e)
        {
            // Khi nhấn vào TextBox, nếu có placeholder, xóa nó
            if (txtUser_name.Text == "Nhập tên người dùng")
            {
                txtUser_name.Text = "";
                txtUser_name.ForeColor = Color.Black;
            }
        }

        private void Payment_And_Billing_Load(object sender, EventArgs e)
        {

        }

        private string GetSelectedRadioButtonText()
        {
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    return rb.Text;  // Return the text of the selected RadioButton
                }
            }
            return string.Empty; // Return an empty string if no RadioButton is selected
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPaymentID.Text))
            {
                int orderid = int.Parse(txtPaymentID.Text);
                listBox1.DataSource = _billsService.GetBillById(orderid);
            }
            else
            {
                listBox1.DataSource = _billsService.GetBills();
            }
        }

        private void btnAddBillPayment_Click(object sender, EventArgs e)
        {
            var PaymentMethod = GetSelectedRadioButtonText();
            var UserName = txtUsername.Text;
            decimal total = 0;

            if (
                !string.IsNullOrEmpty(PaymentMethod) &&
                !string.IsNullOrEmpty(UserName) &&
                decimal.TryParse(txtTotalAmount.Text, out total))
            {
                MessageBox.Show("Đã lập hóa đơn! " + PaymentMethod + "Thông báo " + UserName + " " + total + " " + _selectedOrderId);
                var bill = new Bills
                {
                    OrderID = _selectedOrderId,
                    TotalAmount = total,
                    PaymentMethod = PaymentMethod,
                    PaymentTime = DateTime.Now,
                };
                var billid =_billsService.CreateBills(bill);
                if (billid != 0)
                {
                   _orderService.updateOrderStatus(_selectedOrderId, "Đã thanh toán");
                    MessageBox.Show("Đã Lập thành Hóa đơn thành công");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ");
            }
        }

        private void BtnQRcode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hóa đơn đã được gửi!", "Thông báo");
        }

        // Phương pháp mẫu để tải dữ liệu giả cho đơn hàng
        private void LoadOrderDetails()
        {
            // Sample data for order details
            listViewOrderDetails.Items.Clear();
            listViewOrderDetails.Items.Add(new ListViewItem(new[] { "1", "Phở bò", "2", "40,000" }));
            listViewOrderDetails.Items.Add(new ListViewItem(new[] { "2", "Cơm gà", "1", "35,000" }));
        }

        // Phương pháp mẫu để tải dữ liệu giả cho lịch sử hóa đơn
        private void LoadInvoiceHistory()
        {
            // Sample data for invoices
            listViewInvoiceHistory.Items.Clear();
            listViewInvoiceHistory.Items.Add(new ListViewItem(new[] { "001", "01/12/2024", "75,000" }));
            listViewInvoiceHistory.Items.Add(new ListViewItem(new[] { "002", "02/12/2024", "120,000" }));
        }
    }
}
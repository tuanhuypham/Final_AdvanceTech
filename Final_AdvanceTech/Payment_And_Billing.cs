using System;
using System.Windows.Forms;
using System.Drawing;

namespace Final_AdvanceTech
{
    public partial class Payment_And_Billing : Form
    {
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

        public Payment_And_Billing()
        {
            InitializeComponent();
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

        private void btnAddBillPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lập hóa đơn!", "Thông báo");
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
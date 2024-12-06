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
    public partial class LoginForm : Form
    {
        private const string HardcodedUsername = "admin";
        private const string HardcodedPassword = "password123";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = Account_txt.Text; // Lấy giá trị từ TextBox Username
            string password = Password_txt.Text; // Lấy giá trị từ TextBox Password

            // Kiểm tra thông tin đăng nhập
            if (username == HardcodedUsername && password == HardcodedPassword)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển tới giao diện chính hoặc xử lý tiếp
                this.Hide(); // Ẩn form đăng nhập
                TableService mainForm = new TableService();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

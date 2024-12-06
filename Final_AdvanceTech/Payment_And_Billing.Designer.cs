namespace Final_AdvanceTech
{
    partial class Payment_And_Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnQRcode = new System.Windows.Forms.Button();
            this.btnAddBillPayment = new System.Windows.Forms.Button();
            this.listViewOder = new System.Windows.Forms.ListView();
            this.OderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Online_pay = new System.Windows.Forms.RadioButton();
            this.Redit_Card = new System.Windows.Forms.RadioButton();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PaymentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnQRcode);
            this.tabPage1.Controls.Add(this.btnAddBillPayment);
            this.tabPage1.Controls.Add(this.listViewOder);
            this.tabPage1.Controls.Add(this.txtTotalAmount);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thanh toán";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnQRcode
            // 
            this.BtnQRcode.Location = new System.Drawing.Point(605, 381);
            this.BtnQRcode.Name = "BtnQRcode";
            this.BtnQRcode.Size = new System.Drawing.Size(128, 24);
            this.BtnQRcode.TabIndex = 8;
            this.BtnQRcode.Text = "Mã QR";
            this.BtnQRcode.UseVisualStyleBackColor = true;
            this.BtnQRcode.Click += new System.EventHandler(this.BtnQRcode_Click);
            // 
            // btnAddBillPayment
            // 
            this.btnAddBillPayment.Location = new System.Drawing.Point(439, 381);
            this.btnAddBillPayment.Name = "btnAddBillPayment";
            this.btnAddBillPayment.Size = new System.Drawing.Size(128, 24);
            this.btnAddBillPayment.TabIndex = 7;
            this.btnAddBillPayment.Text = "Lập hóa đơn";
            this.btnAddBillPayment.UseVisualStyleBackColor = true;
            this.btnAddBillPayment.Click += new System.EventHandler(this.btnAddBillPayment_Click);
            // 
            // listViewOder
            // 
            this.listViewOder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OderID,
            this.FoodName,
            this.Quantity,
            this.Price});
            this.listViewOder.HideSelection = false;
            this.listViewOder.Location = new System.Drawing.Point(23, 168);
            this.listViewOder.Name = "listViewOder";
            this.listViewOder.Size = new System.Drawing.Size(723, 156);
            this.listViewOder.TabIndex = 6;
            this.listViewOder.UseCompatibleStateImageBehavior = false;
            this.listViewOder.View = System.Windows.Forms.View.List;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(139, 383);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(153, 22);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(318, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Online_pay);
            this.groupBox1.Controls.Add(this.Redit_Card);
            this.groupBox1.Controls.Add(this.Cash);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // Online_pay
            // 
            this.Online_pay.AutoSize = true;
            this.Online_pay.Location = new System.Drawing.Point(7, 76);
            this.Online_pay.Name = "Online_pay";
            this.Online_pay.Size = new System.Drawing.Size(137, 20);
            this.Online_pay.TabIndex = 2;
            this.Online_pay.TabStop = true;
            this.Online_pay.Text = "Thanh toán điện tử";
            this.Online_pay.UseVisualStyleBackColor = true;
            // 
            // Redit_Card
            // 
            this.Redit_Card.AutoSize = true;
            this.Redit_Card.Location = new System.Drawing.Point(7, 49);
            this.Redit_Card.Name = "Redit_Card";
            this.Redit_Card.Size = new System.Drawing.Size(101, 20);
            this.Redit_Card.TabIndex = 1;
            this.Redit_Card.TabStop = true;
            this.Redit_Card.Text = "Thẻ tín dụng";
            this.Redit_Card.UseVisualStyleBackColor = true;
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(7, 22);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(80, 20);
            this.Cash.TabIndex = 0;
            this.Cash.TabStop = true;
            this.Cash.Text = "Tiền mặt";
            this.Cash.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtPaymentID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiểm tra hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaymentID,
            this.Date,
            this.TotalAmount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 236);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(601, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(211, 57);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(355, 22);
            this.txtPaymentID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(46, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm hóa đơn";
            // 
            // Payment_And_Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.tabControl1);
            this.Name = "Payment_And_Billing";
            this.Text = "Payment_And_Billing";
            this.Load += new System.EventHandler(this.Payment_And_Billing_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Online_pay;
        private System.Windows.Forms.RadioButton Redit_Card;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewOder;
        private System.Windows.Forms.ColumnHeader OderID;
        private System.Windows.Forms.ColumnHeader FoodName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnAddBillPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PaymentID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader TotalAmount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Button BtnQRcode;
    }
}
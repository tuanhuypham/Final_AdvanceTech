namespace Final_AdvanceTech
{
    partial class HumanResources
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commetn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.dateTimePickerWorkDate = new System.Windows.Forms.DateTimePicker();
            this.employId_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddTimeToWork = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.schedulesDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.Year_Performent = new System.Windows.Forms.TextBox();
            this.Month_Performent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowRating = new System.Windows.Forms.Button();
            this.employeePosition_txt = new System.Windows.Forms.TextBox();
            this.employeeID_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.commentPerforment_txt = new System.Windows.Forms.TextBox();
            this.employeesID_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.monthPerforment_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearPerforment_txt = new System.Windows.Forms.TextBox();
            this.monthPerforment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearPerforment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentPerforment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesDataGridView)).BeginInit();
            this.groupBoxEmployeeInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.schedulesDataGridView);
            this.tabPage1.Controls.Add(this.groupBoxEmployeeInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lịch làm việc & Thông tin nhân viên.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployID,
            this.Month,
            this.Year,
            this.Score,
            this.Commetn});
            this.dataGridView1.Location = new System.Drawing.Point(350, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 252);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // EmployID
            // 
            this.EmployID.HeaderText = "Mã nhân viên";
            this.EmployID.MinimumWidth = 6;
            this.EmployID.Name = "EmployID";
            this.EmployID.Width = 125;
            // 
            // Month
            // 
            this.Month.HeaderText = "Tháng";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Năm";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // Score
            // 
            this.Score.HeaderText = "Điểm";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.Width = 125;
            // 
            // Commetn
            // 
            this.Commetn.HeaderText = "Nhận xét";
            this.Commetn.MinimumWidth = 6;
            this.Commetn.Name = "Commetn";
            this.Commetn.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxShift);
            this.groupBox2.Controls.Add(this.dateTimePickerWorkDate);
            this.groupBox2.Controls.Add(this.employId_txt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnAddTimeToWork);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(750, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 213);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm lịch làm việc";
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Location = new System.Drawing.Point(131, 126);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(121, 24);
            this.comboBoxShift.TabIndex = 16;
            // 
            // dateTimePickerWorkDate
            // 
            this.dateTimePickerWorkDate.Location = new System.Drawing.Point(131, 79);
            this.dateTimePickerWorkDate.Name = "dateTimePickerWorkDate";
            this.dateTimePickerWorkDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerWorkDate.TabIndex = 15;
            // 
            // employId_txt
            // 
            this.employId_txt.Location = new System.Drawing.Point(131, 36);
            this.employId_txt.Name = "employId_txt";
            this.employId_txt.Size = new System.Drawing.Size(231, 22);
            this.employId_txt.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã nhân viên";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ngày nhận ca";
            // 
            // btnAddTimeToWork
            // 
            this.btnAddTimeToWork.Location = new System.Drawing.Point(287, 173);
            this.btnAddTimeToWork.Name = "btnAddTimeToWork";
            this.btnAddTimeToWork.Size = new System.Drawing.Size(75, 23);
            this.btnAddTimeToWork.TabIndex = 6;
            this.btnAddTimeToWork.Text = "Thêm";
            this.btnAddTimeToWork.UseVisualStyleBackColor = true;
            this.btnAddTimeToWork.Click += new System.EventHandler(this.btnAddTimeToWork_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Giờ làm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Danh sách lịch làm việc";
            // 
            // schedulesDataGridView
            // 
            this.schedulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeesID,
            this.WorkDate,
            this.Shift});
            this.schedulesDataGridView.Location = new System.Drawing.Point(23, 51);
            this.schedulesDataGridView.Name = "schedulesDataGridView";
            this.schedulesDataGridView.RowHeadersWidth = 51;
            this.schedulesDataGridView.RowTemplate.Height = 24;
            this.schedulesDataGridView.Size = new System.Drawing.Size(670, 207);
            this.schedulesDataGridView.TabIndex = 10;
            this.schedulesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedulesDataGridView_CellContentClick);
            // 
            // EmployeesID
            // 
            this.EmployeesID.HeaderText = "Mã nhân viên";
            this.EmployeesID.MinimumWidth = 6;
            this.EmployeesID.Name = "EmployeesID";
            this.EmployeesID.Width = 125;
            // 
            // WorkDate
            // 
            this.WorkDate.HeaderText = "Ngày làm việc";
            this.WorkDate.MinimumWidth = 6;
            this.WorkDate.Name = "WorkDate";
            this.WorkDate.Width = 125;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Ca làm";
            this.Shift.MinimumWidth = 6;
            this.Shift.Name = "Shift";
            this.Shift.Width = 125;
            // 
            // groupBoxEmployeeInfo
            // 
            this.groupBoxEmployeeInfo.Controls.Add(this.Year_Performent);
            this.groupBoxEmployeeInfo.Controls.Add(this.Month_Performent);
            this.groupBoxEmployeeInfo.Controls.Add(this.label7);
            this.groupBoxEmployeeInfo.Controls.Add(this.btnShowRating);
            this.groupBoxEmployeeInfo.Controls.Add(this.employeePosition_txt);
            this.groupBoxEmployeeInfo.Controls.Add(this.employeeID_txt);
            this.groupBoxEmployeeInfo.Controls.Add(this.label2);
            this.groupBoxEmployeeInfo.Controls.Add(this.label1);
            this.groupBoxEmployeeInfo.Location = new System.Drawing.Point(6, 264);
            this.groupBoxEmployeeInfo.Name = "groupBoxEmployeeInfo";
            this.groupBoxEmployeeInfo.Size = new System.Drawing.Size(338, 258);
            this.groupBoxEmployeeInfo.TabIndex = 7;
            this.groupBoxEmployeeInfo.TabStop = false;
            this.groupBoxEmployeeInfo.Text = "Thông tin";
            // 
            // Year_Performent
            // 
            this.Year_Performent.Location = new System.Drawing.Point(239, 38);
            this.Year_Performent.Name = "Year_Performent";
            this.Year_Performent.Size = new System.Drawing.Size(82, 22);
            this.Year_Performent.TabIndex = 10;
            // 
            // Month_Performent
            // 
            this.Month_Performent.Location = new System.Drawing.Point(138, 38);
            this.Month_Performent.Name = "Month_Performent";
            this.Month_Performent.Size = new System.Drawing.Size(82, 22);
            this.Month_Performent.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tháng / năm";
            // 
            // btnShowRating
            // 
            this.btnShowRating.Location = new System.Drawing.Point(239, 211);
            this.btnShowRating.Name = "btnShowRating";
            this.btnShowRating.Size = new System.Drawing.Size(75, 23);
            this.btnShowRating.TabIndex = 7;
            this.btnShowRating.Text = "Xem";
            this.btnShowRating.UseVisualStyleBackColor = true;
            this.btnShowRating.Click += new System.EventHandler(this.btnShowRating_Click);
            // 
            // employeePosition_txt
            // 
            this.employeePosition_txt.Location = new System.Drawing.Point(138, 125);
            this.employeePosition_txt.Name = "employeePosition_txt";
            this.employeePosition_txt.Size = new System.Drawing.Size(183, 22);
            this.employeePosition_txt.TabIndex = 4;
            // 
            // employeeID_txt
            // 
            this.employeeID_txt.Location = new System.Drawing.Point(138, 79);
            this.employeeID_txt.Name = "employeeID_txt";
            this.employeeID_txt.Size = new System.Drawing.Size(183, 22);
            this.employeeID_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridViewEmployees);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1130, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đánh giá hiệu suất";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Controls.Add(this.yearPerforment_txt);
            this.groupBox1.Controls.Add(this.monthPerforment_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.commentPerforment_txt);
            this.groupBox1.Controls.Add(this.employeesID_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(237, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(381, 218);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 31);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 31);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Xác nhận";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // commentPerforment_txt
            // 
            this.commentPerforment_txt.Location = new System.Drawing.Point(215, 179);
            this.commentPerforment_txt.Name = "commentPerforment_txt";
            this.commentPerforment_txt.Size = new System.Drawing.Size(255, 22);
            this.commentPerforment_txt.TabIndex = 5;
            // 
            // employeesID_txt
            // 
            this.employeesID_txt.Location = new System.Drawing.Point(215, 107);
            this.employeesID_txt.Name = "employeesID_txt";
            this.employeesID_txt.Size = new System.Drawing.Size(87, 22);
            this.employeesID_txt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đánh giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hiệu suất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthPerforment,
            this.yearPerforment,
            this.employmentID,
            this.commentPerforment,
            this.efficiency});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(173, 34);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(668, 217);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // monthPerforment_txt
            // 
            this.monthPerforment_txt.Location = new System.Drawing.Point(215, 68);
            this.monthPerforment_txt.Name = "monthPerforment_txt";
            this.monthPerforment_txt.Size = new System.Drawing.Size(87, 22);
            this.monthPerforment_txt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tháng / năm";
            // 
            // yearPerforment_txt
            // 
            this.yearPerforment_txt.Location = new System.Drawing.Point(331, 68);
            this.yearPerforment_txt.Name = "yearPerforment_txt";
            this.yearPerforment_txt.Size = new System.Drawing.Size(87, 22);
            this.yearPerforment_txt.TabIndex = 11;
            // 
            // monthPerforment
            // 
            this.monthPerforment.HeaderText = "Tháng";
            this.monthPerforment.MinimumWidth = 6;
            this.monthPerforment.Name = "monthPerforment";
            this.monthPerforment.Width = 125;
            // 
            // yearPerforment
            // 
            this.yearPerforment.HeaderText = "Năm";
            this.yearPerforment.MinimumWidth = 6;
            this.yearPerforment.Name = "yearPerforment";
            this.yearPerforment.Width = 125;
            // 
            // employmentID
            // 
            this.employmentID.HeaderText = "Mã nhân viên";
            this.employmentID.MinimumWidth = 6;
            this.employmentID.Name = "employmentID";
            this.employmentID.Width = 125;
            // 
            // commentPerforment
            // 
            this.commentPerforment.HeaderText = "Đánh giá";
            this.commentPerforment.MinimumWidth = 6;
            this.commentPerforment.Name = "commentPerforment";
            this.commentPerforment.Width = 125;
            // 
            // efficiency
            // 
            this.efficiency.HeaderText = "Hiệu suất";
            this.efficiency.MinimumWidth = 6;
            this.efficiency.Name = "efficiency";
            this.efficiency.Width = 125;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(215, 144);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(87, 22);
            this.txtScore.TabIndex = 12;
            // 
            // HumanResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 571);
            this.Controls.Add(this.tabControl1);
            this.Name = "HumanResources";
            this.Text = "HumanResources";
            this.Load += new System.EventHandler(this.HumanResources_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesDataGridView)).EndInit();
            this.groupBoxEmployeeInfo.ResumeLayout(false);
            this.groupBoxEmployeeInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxEmployeeInfo;
        private System.Windows.Forms.TextBox employeePosition_txt;
        private System.Windows.Forms.TextBox employeeID_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowRating;
        private System.Windows.Forms.Button btnAddTimeToWork;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox commentPerforment_txt;
        private System.Windows.Forms.TextBox employeesID_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Month_Performent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox employId_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView schedulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commetn;
        private System.Windows.Forms.TextBox Year_Performent;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkDate;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.TextBox monthPerforment_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearPerforment_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthPerforment;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearPerforment;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentPerforment;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiency;
        private System.Windows.Forms.TextBox txtScore;
    }
}
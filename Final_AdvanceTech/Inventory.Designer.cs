namespace Final_AdvanceTech
{
    partial class Inventory
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInventory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Inventory_DGV = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLog_DGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Reload_btn = new System.Windows.Forms.Button();
            this.SafeThreshold_txt = new System.Windows.Forms.TextBox();
            this.CurrentStock_txt = new System.Windows.Forms.TextBox();
            this.tabControlInventory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChangeAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchCurrent_btn = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewitem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLog_DGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControlInventory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartInventory
            // 
            chartArea7.Name = "ChartArea1";
            this.chartInventory.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartInventory.Legends.Add(legend7);
            this.chartInventory.Location = new System.Drawing.Point(98, 76);
            this.chartInventory.Name = "chartInventory";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartInventory.Series.Add(series7);
            this.chartInventory.Size = new System.Drawing.Size(391, 300);
            this.chartInventory.TabIndex = 1;
            this.chartInventory.Text = "chart2";
            // 
            // Inventory_DGV
            // 
            this.Inventory_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory_DGV.Location = new System.Drawing.Point(6, 244);
            this.Inventory_DGV.Name = "Inventory_DGV";
            this.Inventory_DGV.RowHeadersWidth = 51;
            this.Inventory_DGV.RowTemplate.Height = 24;
            this.Inventory_DGV.Size = new System.Drawing.Size(776, 232);
            this.Inventory_DGV.TabIndex = 12;
            this.Inventory_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inventory_DGV_CellContentClick);
            // 
            // Type
            // 
            this.Type.HeaderText = "Loại";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // ChangeDate
            // 
            this.ChangeDate.HeaderText = "Ngày";
            this.ChangeDate.MinimumWidth = 6;
            this.ChangeDate.Name = "ChangeDate";
            this.ChangeDate.Width = 125;
            // 
            // ChangeAmount
            // 
            this.ChangeAmount.HeaderText = "Thay đổi";
            this.ChangeAmount.MinimumWidth = 6;
            this.ChangeAmount.Name = "ChangeAmount";
            this.ChangeAmount.Width = 125;
            // 
            // itemID
            // 
            this.itemID.HeaderText = "Mã hàng hóa";
            this.itemID.MinimumWidth = 6;
            this.itemID.Name = "itemID";
            this.itemID.Width = 125;
            // 
            // inventoryLog_DGV
            // 
            this.inventoryLog_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryLog_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.ChangeAmount,
            this.ChangeDate,
            this.Type});
            this.inventoryLog_DGV.Location = new System.Drawing.Point(6, 6);
            this.inventoryLog_DGV.Name = "inventoryLog_DGV";
            this.inventoryLog_DGV.RowHeadersWidth = 51;
            this.inventoryLog_DGV.RowTemplate.Height = 24;
            this.inventoryLog_DGV.Size = new System.Drawing.Size(776, 223);
            this.inventoryLog_DGV.TabIndex = 21;
            this.inventoryLog_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryLog_DGV_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartInventory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1183, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xem báo cáo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Reload_btn
            // 
            this.Reload_btn.Location = new System.Drawing.Point(140, 193);
            this.Reload_btn.Name = "Reload_btn";
            this.Reload_btn.Size = new System.Drawing.Size(91, 33);
            this.Reload_btn.TabIndex = 24;
            this.Reload_btn.Text = "Tải lại";
            this.Reload_btn.UseVisualStyleBackColor = true;
            this.Reload_btn.Click += new System.EventHandler(this.Reload_btn_Click);
            // 
            // SafeThreshold_txt
            // 
            this.SafeThreshold_txt.Location = new System.Drawing.Point(140, 136);
            this.SafeThreshold_txt.Name = "SafeThreshold_txt";
            this.SafeThreshold_txt.Size = new System.Drawing.Size(121, 22);
            this.SafeThreshold_txt.TabIndex = 23;
            // 
            // CurrentStock_txt
            // 
            this.CurrentStock_txt.Location = new System.Drawing.Point(140, 85);
            this.CurrentStock_txt.Name = "CurrentStock_txt";
            this.CurrentStock_txt.Size = new System.Drawing.Size(121, 22);
            this.CurrentStock_txt.TabIndex = 22;
            // 
            // tabControlInventory
            // 
            this.tabControlInventory.Controls.Add(this.tabPage1);
            this.tabControlInventory.Controls.Add(this.tabPage2);
            this.tabControlInventory.Location = new System.Drawing.Point(10, 12);
            this.tabControlInventory.Name = "tabControlInventory";
            this.tabControlInventory.SelectedIndex = 0;
            this.tabControlInventory.Size = new System.Drawing.Size(1191, 511);
            this.tabControlInventory.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.inventoryLog_DGV);
            this.tabPage1.Controls.Add(this.Inventory_DGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1183, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách hàng hóa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtChangeAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtItemID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(788, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 223);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập - Xuất kho hàng";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(140, 120);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nhập / Xuất";
            // 
            // txtChangeAmount
            // 
            this.txtChangeAmount.Location = new System.Drawing.Point(140, 77);
            this.txtChangeAmount.Name = "txtChangeAmount";
            this.txtChangeAmount.Size = new System.Drawing.Size(91, 22);
            this.txtChangeAmount.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số lượng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(268, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 33);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(140, 40);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(91, 22);
            this.txtItemID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã hàng hóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reload_btn);
            this.groupBox1.Controls.Add(this.SafeThreshold_txt);
            this.groupBox1.Controls.Add(this.CurrentStock_txt);
            this.groupBox1.Controls.Add(this.searchCurrent_btn);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddNewitem);
            this.groupBox1.Location = new System.Drawing.Point(788, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 232);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kho hàng";
            // 
            // searchCurrent_btn
            // 
            this.searchCurrent_btn.Location = new System.Drawing.Point(16, 193);
            this.searchCurrent_btn.Name = "searchCurrent_btn";
            this.searchCurrent_btn.Size = new System.Drawing.Size(90, 33);
            this.searchCurrent_btn.TabIndex = 21;
            this.searchCurrent_btn.Text = "Tìm kiếm";
            this.searchCurrent_btn.UseVisualStyleBackColor = true;
            this.searchCurrent_btn.Click += new System.EventHandler(this.searchCurrent_btn_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(140, 32);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(218, 22);
            this.txtItemName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số lượng hiện có";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tối thiểu";
            // 
            // btnAddNewitem
            // 
            this.btnAddNewitem.Location = new System.Drawing.Point(268, 193);
            this.btnAddNewitem.Name = "btnAddNewitem";
            this.btnAddNewitem.Size = new System.Drawing.Size(90, 33);
            this.btnAddNewitem.TabIndex = 17;
            this.btnAddNewitem.Text = "Thêm";
            this.btnAddNewitem.UseVisualStyleBackColor = true;
            this.btnAddNewitem.Click += new System.EventHandler(this.btnAddNewitem_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 535);
            this.Controls.Add(this.tabControlInventory);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLog_DGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControlInventory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventory;
        private System.Windows.Forms.DataGridView Inventory_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridView inventoryLog_DGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Reload_btn;
        private System.Windows.Forms.TextBox SafeThreshold_txt;
        private System.Windows.Forms.TextBox CurrentStock_txt;
        private System.Windows.Forms.TabControl tabControlInventory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChangeAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchCurrent_btn;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewitem;
    }
}
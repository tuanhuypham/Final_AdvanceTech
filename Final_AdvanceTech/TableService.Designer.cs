namespace Final_AdvanceTech
{
    partial class TableService
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
            this.treeViewTables = new System.Windows.Forms.TreeView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnShowNotifications = new System.Windows.Forms.Button();
            this.DataGridOrderDishes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrderDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewTables
            // 
            this.treeViewTables.Location = new System.Drawing.Point(21, 21);
            this.treeViewTables.Name = "treeViewTables";
            this.treeViewTables.Size = new System.Drawing.Size(315, 309);
            this.treeViewTables.TabIndex = 0;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(21, 383);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(91, 37);
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.Text = "Gọi món";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(127, 383);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(93, 37);
            this.btnUpdateStatus.TabIndex = 3;
            this.btnUpdateStatus.Text = "Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnShowNotifications
            // 
            this.btnShowNotifications.Location = new System.Drawing.Point(237, 383);
            this.btnShowNotifications.Name = "btnShowNotifications";
            this.btnShowNotifications.Size = new System.Drawing.Size(99, 37);
            this.btnShowNotifications.TabIndex = 4;
            this.btnShowNotifications.Text = "Notifications";
            this.btnShowNotifications.UseVisualStyleBackColor = true;
            this.btnShowNotifications.Click += new System.EventHandler(this.btnShowNotifications_Click);
            // 
            // DataGridOrderDishes
            // 
            this.DataGridOrderDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOrderDishes.Location = new System.Drawing.Point(409, 21);
            this.DataGridOrderDishes.Name = "DataGridOrderDishes";
            this.DataGridOrderDishes.RowHeadersWidth = 51;
            this.DataGridOrderDishes.RowTemplate.Height = 24;
            this.DataGridOrderDishes.Size = new System.Drawing.Size(551, 496);
            this.DataGridOrderDishes.TabIndex = 1;
            this.DataGridOrderDishes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderDetails_CellContentClick);
            // 
            // TableService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 552);
            this.Controls.Add(this.btnShowNotifications);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.DataGridOrderDishes);
            this.Controls.Add(this.treeViewTables);
            this.Name = "TableService";
            this.Text = "TableService";
            this.Load += new System.EventHandler(this.TableService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrderDishes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewTables;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnShowNotifications;
        private System.Windows.Forms.DataGridView DataGridOrderDishes;
    }
}
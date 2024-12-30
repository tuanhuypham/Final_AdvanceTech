namespace Final_AdvanceTech
{
    partial class KitchenForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnCooking = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(42, 21);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(680, 311);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // btnPrepare
            // 
            this.btnPrepare.Location = new System.Drawing.Point(784, 48);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(108, 34);
            this.btnPrepare.TabIndex = 1;
            this.btnPrepare.Text = "Đang chuẩn bị";
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // btnCooking
            // 
            this.btnCooking.Location = new System.Drawing.Point(784, 149);
            this.btnCooking.Name = "btnCooking";
            this.btnCooking.Size = new System.Drawing.Size(95, 34);
            this.btnCooking.TabIndex = 2;
            this.btnCooking.Text = "Đang nấu";
            this.btnCooking.UseVisualStyleBackColor = true;
            this.btnCooking.Click += new System.EventHandler(this.btnCooking_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(784, 260);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(95, 34);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "Hoàn thành";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 385);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnCooking);
            this.Controls.Add(this.btnPrepare);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "KitchenForm";
            this.Text = "KitchenForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Button btnCooking;
        private System.Windows.Forms.Button btnComplete;
    }
}
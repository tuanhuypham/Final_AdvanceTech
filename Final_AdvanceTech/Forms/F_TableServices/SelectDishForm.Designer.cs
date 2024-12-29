namespace Final_AdvanceTech.Forms.FTableServices
{
    partial class SelectDishForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListDish = new System.Windows.Forms.ListBox();
            this.SelectedDisesGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetCurrentDishes = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDisesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select dishes";
            // 
            // ListDish
            // 
            this.ListDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDish.FormattingEnabled = true;
            this.ListDish.ItemHeight = 22;
            this.ListDish.Location = new System.Drawing.Point(31, 56);
            this.ListDish.Name = "ListDish";
            this.ListDish.Size = new System.Drawing.Size(757, 202);
            this.ListDish.TabIndex = 2;
            // 
            // SelectedDisesGridView
            // 
            this.SelectedDisesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedDisesGridView.Location = new System.Drawing.Point(31, 319);
            this.SelectedDisesGridView.Name = "SelectedDisesGridView";
            this.SelectedDisesGridView.RowHeadersWidth = 51;
            this.SelectedDisesGridView.RowTemplate.Height = 24;
            this.SelectedDisesGridView.Size = new System.Drawing.Size(757, 150);
            this.SelectedDisesGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Dish you Select";
            // 
            // btnResetCurrentDishes
            // 
            this.btnResetCurrentDishes.Location = new System.Drawing.Point(676, 290);
            this.btnResetCurrentDishes.Name = "btnResetCurrentDishes";
            this.btnResetCurrentDishes.Size = new System.Drawing.Size(112, 23);
            this.btnResetCurrentDishes.TabIndex = 4;
            this.btnResetCurrentDishes.Text = "Reset";
            this.btnResetCurrentDishes.UseVisualStyleBackColor = true;
            this.btnResetCurrentDishes.Click += new System.EventHandler(this.btnResetCurrentDishes_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(291, 493);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(112, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Gọi";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(445, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnResetCurrentDishes);
            this.Controls.Add(this.SelectedDisesGridView);
            this.Controls.Add(this.ListDish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelectDishForm";
            this.Text = "SelectDishForm";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDisesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListDish;
        private System.Windows.Forms.DataGridView SelectedDisesGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResetCurrentDishes;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
    }
}
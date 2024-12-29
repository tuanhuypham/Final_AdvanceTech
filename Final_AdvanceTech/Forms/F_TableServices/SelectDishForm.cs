using Final_AdvanceTech.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_AdvanceTech.Forms.FTableServices
{
    public partial class SelectDishForm : Form
    {
        public List<OrderDishes> CurrentOrderDishes = new List<OrderDishes>();
        public List<Dishes> Dishes = new List<Dishes>();
        private int CurrentTable;
        private BindingSource bindingSource;
        public SelectDishForm()
        {
            InitializeComponent();
        }

        public SelectDishForm(List<Dishes> dishes,int table)
        {
            InitializeComponent();

            //khoi tao ban hien tai
            CurrentTable = table;

            //Khoi tao ListBox tat ca mon an
            ListDish.DataSource = dishes;
            ListDish.DisplayMember = "DisplayDish";
            ListDish.DoubleClick += ListDish_DoubleClick;

            //Khoi tao GridView tat ca mon an nguoi dung chon
            Dishes = dishes;

            bindingSource = new BindingSource();
            bindingSource.DataSource = CurrentOrderDishes;
            SelectedDisesGridView.Columns.Add("dishName", "Dish Name");
            SelectedDisesGridView.Columns.Add("dishPrice", "Dish Price");
            SelectedDisesGridView.DataSource = bindingSource;


            SelectedDisesGridView.CellFormatting += SelectedDisesGridView_CellFormatting;
        }

        private void SelectedDisesGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu là dòng hợp lệ
            {
                if (CurrentOrderDishes.Count > 0)
                {
                    // Lấy giá trị từ cột "Price" ở dòng hiện tại
                    if (SelectedDisesGridView.Rows[e.RowIndex].Cells["dish_id"].Value != null)
                    {
                        var dishid = (int)SelectedDisesGridView.Rows[e.RowIndex].Cells["dish_id"].Value;
                        var dish = GetDishById(dishid);
                        SelectedDisesGridView.Rows[e.RowIndex].Cells["dishName"].Value = dish.Name;
                        SelectedDisesGridView.Rows[e.RowIndex].Cells["dishPrice"].Value = dish.Price;
                    }
                }
            }
        }

        public Dishes GetDishById(int id)
        {
            return Dishes.Where(d => d.dish_id == id).FirstOrDefault();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListDish_DoubleClick(object sender, EventArgs e)
        {
            if (ListDish.SelectedItem != null)
            {   
                // lay mon an hien tai
                Dishes selectedDish = ListDish.SelectedItem as Dishes;
                var orderDish = CurrentOrderDishes.FirstOrDefault(o => o.dish_id == selectedDish.dish_id);

                if (orderDish == null)
                {
                    CurrentOrderDishes.Add(new OrderDishes
                    {
                        dish_id = selectedDish.dish_id,
                        order_id = CurrentTable,
                        note = "",
                        quantity = 1
                    });
                }
                else
                {
                    orderDish.quantity += 1;
                }
                bindingSource.ResetBindings(false);
            }
        }

        private void btnResetCurrentDishes_Click(object sender, EventArgs e)
        {
            CurrentOrderDishes.Clear();
            SelectedDisesGridView.Rows.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CurrentOrderDishes.Clear();
            SelectedDisesGridView.Rows.Clear();
            this.Close();
        }
    }
}

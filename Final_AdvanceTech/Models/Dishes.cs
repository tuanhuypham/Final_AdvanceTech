using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Models
{
    public class Dishes
    {
        public int dish_id { get; set; }  // Tên món ăn
        public string Name { get; set; }  // Tên món ăn
        public decimal Price { get; set; }  // Giá của món ăn
        public string Note { get; set; }  // Ghi chú về món ăn


        public string DisplayDish => $"{Name} - {Price} - {Note}"; //Bien Hien thi ten mon an (dc dung cho ui)
    }
}

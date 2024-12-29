using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Models
{
    public class OrderDishes
    {
        public int order_id { get; set; }
        public int dish_id { get; set; }
        public int quantity { get; set; }
        public string note { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Models
{
    public class OrderDetail
    {
        public int? OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int MenuItemID { get; set; }
        public int quantity { get; set; }
        public string note { get; set; }
    }
}

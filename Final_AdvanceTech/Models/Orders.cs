using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Models
{
    public class Orders
    {
        public int order_id { get; set; }
        public int table_id { get; set; }
        public int customer_id { get; set; }
        public decimal total_amount { get; set; } = 0; 
        public DateTime order_time { get; set; }
        public string Order_status { get; set; }
        public string payment_status { get; set; }
    }
}

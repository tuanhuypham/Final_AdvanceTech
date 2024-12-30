using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_AdvanceTech.Models
{
    public class Bills
    {
        public int BillId { get; set; }
        public int OrderID { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentTime { get; set; }

        public string DisplayBills => $"{OrderID} - {TotalAmount} - {PaymentMethod} - {PaymentTime}"; 
    }
}

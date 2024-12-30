using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_AdvanceTech.Models
{
    public class Menus
    {
        public int MenuItemID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }


        public string DisplayMenu => $"{ItemName} - {Price} - {Category}"; //Bien Hien thi ten mon an (dc dung cho ui)
    }
}

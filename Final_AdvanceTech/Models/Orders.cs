﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Models
{
    public class Orders
    {
        public int? OrderID { get; set; }
        public int TableID { get; set; }
        public DateTime OrderTime { get; set; }
        public string Status { get; set; } 
    }
}

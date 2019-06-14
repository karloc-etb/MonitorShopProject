﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETProject.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int MonitorId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Monitor Monitor { get; set; }
        public virtual Order Order { get; set; }
        public ShoppingCartViewModel ShoppingCartViewModel { get; set; }
    }
}

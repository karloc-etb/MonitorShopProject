using ASP.NETProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETProject.Views
{
    public class ShoppingCartViewModel
    {
        public int Id { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}

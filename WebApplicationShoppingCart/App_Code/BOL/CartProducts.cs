using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationShoppingCart.App_Code.BOL
{
    public class CartProducts
    {
        public int CartID { get; set; }
        public int HowMany { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
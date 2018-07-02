using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationShoppingCart.App_Code.BOL
{
    public class Cart
    {
        
        public int CartID { get; set; }
        public bool Paid { get; set; }
        public List<CartProducts> List { get; set; }
}
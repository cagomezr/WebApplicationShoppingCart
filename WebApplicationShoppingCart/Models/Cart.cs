using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplicationShoppingCart.Models
{
    public class Cart
    {

        [ScaffoldColumn(false)]
        public int CartID { get; set; }

        [StringLength(100), Display(Name = "Shopping Cart Name")]
        public string CartName { get; set; }

        public string UserID { get; set; }

        public String Products { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationShoppingCart.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int UserID { get; set; }
        [Required, StringLength(100), Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required, StringLength(100), Display(Name = "Password")]
        public string Password { get; set; }

    }
}
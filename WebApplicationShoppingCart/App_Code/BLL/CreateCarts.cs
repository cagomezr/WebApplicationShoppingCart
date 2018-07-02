using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationShoppingCart.App_Code.DAL;
using WebApplicationShoppingCart.App_Code.DAL.Entity;

namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class CreateCarts
    {
        public bool CreateCart(int UserId)
        {
            bool returnbool = false;
            try
            {
                using (NorthwindEntities context = new NorthwindEntities())
                {
                    context.spCreateCart(UserId);
                }
            }
            catch (Exception ex) { }
            return returnbool;
        }
    }
}
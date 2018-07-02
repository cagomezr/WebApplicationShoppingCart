using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationShoppingCart.App_Code.DAL;
using WebApplicationShoppingCart.App_Code.DAL.Entity;


namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class PayCarts
    {
        public bool PayCart (int CartId)
        {
            bool returnbool = true;
            try
            {
                using (NorthwindEntities context = new NorthwindEntities())
                {
                    context.spPaidCart_(CartId);
                }
            }
            catch (Exception ex) { returnbool = false; }
            return returnbool;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationShoppingCart.App_Code.DAL;
using WebApplicationShoppingCart.App_Code.DAL.Entity;

namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class AddProducts
    {
        public bool AddProduct(int cartID,int productID, int quantity)
        {
            bool returnbool = true;
            try
            {
                using (NorthwindEntities context = new NorthwindEntities())
                {
                    context.spAddProductToCart(cartID, productID, quantity);
                }
            }catch(Exception ex){returnbool = false; }
            return returnbool;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationShoppingCart.App_Code.DAL.Entity;

namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class GetProducts
    {
        public IEnumerable<spGetProduct_Result> GetProductList()
        {
            try
            {
                using (NorthwindEntities context = new NorthwindEntities())
                {
                    IEnumerable<spGetProduct_Result> ProductList = context.spGetProduct();
                    return ProductList;
                }
            }
            catch (Exception ex)
            {
                IEnumerable<spGetProduct_Result> ProductListEmpty = Enumerable.Empty<spGetProduct_Result>();
                return ProductListEmpty;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationShoppingCart.App_Code.DAL.Entity;

namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class GetCategories
    {
        public IEnumerable<spGetCategory_Result> GetCategoryList()
        {
            
            try
            {
                using (NorthwindEntities context = new NorthwindEntities())
                {
                    IEnumerable<spGetCategory_Result> CategoryList = context.spGetCategory();
                    return CategoryList;
                }
            }
            catch (Exception ex) {
                IEnumerable<spGetCategory_Result> CategoryListEmpty = Enumerable.Empty<spGetCategory_Result>();
                return CategoryListEmpty;
            }
           
        }
    }
}
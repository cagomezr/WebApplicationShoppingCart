using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationShoppingCart.App_Code.DAL.Entity;

namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class GetUsers
    {
        public spGetUser_Result GetUser(string username)
        {
            spGetUser_Result returnUser;
            try
            {
                using (NorthwindEntities context = new NorthwindEntities())
                {
                    IEnumerable<spGetUser_Result> user = context.spGetUser(username);
                    returnUser = user.First();
                }
            }
            catch (Exception ex) {
                returnUser = new spGetUser_Result();
                returnUser.username = "invalid";
            }

            return returnUser;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplicationShoppingCart.App_Code.DAL.Entity;

namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class LoginAuth
    {

        public bool Authorize(string user, string password)
        {
            bool auth = false;
            string publicuser = WebConfigurationManager.AppSettings["PFUserName"];
            string publicpass = WebConfigurationManager.AppSettings["PFPassWord"];
            if (user.Equals(publicuser) && password.Equals(publicpass))
            {
                auth = true;
            }
            else
            {
                GetUsers BLLUserCall = new GetUsers();
                spGetUser_Result Check= BLLUserCall.GetUser(user);// ifuser exists
                if (!Check.username.Equals("invalid"))
                {
                    if (Check.Password.Equals(password))
                    {
                        auth = true;
                    }
                }
            }
            return auth;
        }
    }
    
}
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using WebApplicationShoppingCart.App_Code.DAL.ADO;

namespace WebApplicationShoppingCart.App_Code.BLL
{
    public class ProductOperation
    {

        public DataTable GetProducts()
        {
            string ConnectionString =
               ConfigurationManager.AppSettings
               ["ConnectionString"];
            DatabaseType dbtype = DatabaseType.SQLServer;//default if  app is extended change would be added on the connectuon
            IDbConnection cnn =
                ADODataLayer.CreateConnection
                (ConnectionString, dbtype);

            string cmdString = "spGetProduct";

            IDbCommand cmd =
               ADODataLayer.CreateCommand(
               cmdString, dbtype, cnn);

            DbDataAdapter da =
               ADODataLayer.CreateAdapter(cmd, dbtype);

            DataTable dt = new DataTable("Customers");

            da.Fill(dt);

            return dt;
        }
        public Decimal getProductPrice(string[] productids)
        {
            decimal returndata = 0;
            return returndata;
        }
    }
}
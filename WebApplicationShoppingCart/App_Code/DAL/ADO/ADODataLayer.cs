using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace WebApplicationShoppingCart.App_Code.DAL.ADO
{
    
        public enum DatabaseType
        {
            SQLServer
            // any other data source type can be added at later  times
        }

        public enum ParameterType
        {
            Integer,
            Char,
            VarChar
            // define a common parameter type set
        }

          public class ADODataLayer
         {
            private ADODataLayer() { }

            public static IDbConnection CreateConnection
               (string ConnectionString,
               DatabaseType dbtype)
            {
                IDbConnection cnn;

                switch (dbtype)
                {

                    case DatabaseType.SQLServer:
                        cnn = new SqlConnection
                           (ConnectionString);
                        break;

                    default:
                        cnn = new SqlConnection
                           (ConnectionString);
                        break;
                }//scalable to other  databases

                return cnn;
            }


            public static IDbCommand CreateCommand
               (string CommandText, DatabaseType dbtype,
               IDbConnection cnn)
            {
                IDbCommand cmd;
                switch (dbtype)
                {

                    case DatabaseType.SQLServer:
                        cmd = new SqlCommand
                           (CommandText,
                           (SqlConnection)cnn);
                        break;


                    default:
                        cmd = new SqlCommand
                           (CommandText,
                           (SqlConnection)cnn);
                        break;
                }// scalable to other SQL systems


                return cmd;
            }


            public static DbDataAdapter CreateAdapter
               (IDbCommand cmd, DatabaseType dbtype)
            {
                DbDataAdapter da;
                switch (dbtype)
                {

                    case DatabaseType.SQLServer:
                        da = new SqlDataAdapter
                           ((SqlCommand)cmd);
                        break;


                    default:
                        da = new SqlDataAdapter
                           ((SqlCommand)cmd);
                        break;
                }

                return da;
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using DLL;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.

public class Service : IService

{
    public string GetData(int cart)
    {
        string cartData = cart.ToString();
        cartData += "test";
        //return String.Format("Hello {0}", cartData);

        int data = 0;
        try { data = cart; }
        catch(Exception ex) { 
           
            return "No data";
        }
        String returntable = "<table><tr>";
        returntable += "<th>Product </th><th>Ammount </th><th>Price Per product  </th><th>Total </th></tr>";
        using (NorthWindEntities context = new NorthWindEntities())
        {
            IEnumerable<CartContent> Cart = context.spGetCart(cart);
            foreach (CartContent product in Cart)
            {
                returntable += "<tr><td>" + product.ProductName + "</td><td>" + product.HowMany.ToString() + "</td><td>" + product.UnitPrice.ToString() + "</td><td>" + (product.UnitPrice * (Convert.ToDecimal(product.HowMany))).ToString() + "</td></tr>";

            }
        }
        returntable += "<table>";
        return returntable;
    }

   
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationShoppingCart.App_Code.DAL.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NorthwindEntities : DbContext
    {
        public NorthwindEntities()
            : base("name=NorthwindEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int spAddProductToCart(Nullable<int> cartId, Nullable<int> productID, Nullable<int> quantity)
        {
            var cartIdParameter = cartId.HasValue ?
                new ObjectParameter("CartId", cartId) :
                new ObjectParameter("CartId", typeof(int));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddProductToCart", cartIdParameter, productIDParameter, quantityParameter);
        }
    
        public virtual int spCreateCart(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCreateCart", userIdParameter);
        }
    
        public virtual ObjectResult<spGetCart_Result> spGetCart(Nullable<int> cart)
        {
            var cartParameter = cart.HasValue ?
                new ObjectParameter("Cart", cart) :
                new ObjectParameter("Cart", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCart_Result>("spGetCart", cartParameter);
        }
    
        public virtual ObjectResult<spGetCategory_Result> spGetCategory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCategory_Result>("spGetCategory");
        }
    
        public virtual ObjectResult<spGetProduct_Result> spGetProduct()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetProduct_Result>("spGetProduct");
        }
    
        public virtual ObjectResult<spGetUser_Result> spGetUser(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUser_Result>("spGetUser", userNameParameter);
        }
    
        public virtual int spPaidCart_(Nullable<int> cartId)
        {
            var cartIdParameter = cartId.HasValue ?
                new ObjectParameter("CartId", cartId) :
                new ObjectParameter("CartId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spPaidCart_", cartIdParameter);
        }
    }
}

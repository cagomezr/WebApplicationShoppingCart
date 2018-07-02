<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationShoppingCart._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:LoginView ID="ShopLoginView" runat="server">
        <AnonymousTemplate>
            you are currentlyu&nbsp; not logged in
        </AnonymousTemplate>
        <LoggedInTemplate>
            <div>
                Welcome!m
                <asp:GridView ID="ProductGrid" runat="server"></asp:GridView>
            </div>
        </LoggedInTemplate>
    </asp:LoginView>

</asp:Content>

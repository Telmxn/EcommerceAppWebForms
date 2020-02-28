<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcommerceAppWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="margin-top:35px;">
        <div class="col-md-4">
            <div>
                <label for="MainContent_txbx_username">Please Enter UserName:</label>
                <asp:TextBox ID="txbx_username" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <label for="MainContent_txbx_email">Please Enter Email:</label>
                <asp:TextBox ID="txbx_email" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <label for="MainContent_txbx_password">Please Enter Password:</label>
                <asp:TextBox ID="txbx_password" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <button ID="btn_register" runat="server" class="btn btn-success" style="margin:10px 100px">Register</button>
        </div>
    </div>

</asp:Content>

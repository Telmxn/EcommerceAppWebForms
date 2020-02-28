<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcommerceAppWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="margin-top:65px;">
        <div class="col-md-4">
            <div>
                <label for="MainContent_txbx_username">Please Enter UserName:</label>
                <input ID="Username" type="text" class="form-control" name="Username"/>
            </div>
            <div>
                <label for="MainContent_txbx_email">Please Enter Email:</label>
                <input ID="Email" type="email" class="form-control" name="Email" />
            </div>
            <div>
                <label for="MainContent_txbx_password">Please Enter Password:</label>
                <input ID="Password" type="password" class="form-control" name="Password" />
            </div>
            <button ID="btn_register" runat="server" class="btn btn-success" style="margin:10px 100px">Register</button>
        </div>
    </div>

</asp:Content>

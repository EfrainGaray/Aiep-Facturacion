<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Aiep_Facturacion.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="detalle" runat="server">
    <div class="col-8 text-white font-weight-bold">
        <div class="form-group">
            <label for="exampleInputEmail1">Email address</label>
          
            <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
         
        </div>

        <div class="form-group">
            <label for="exampleInputPassword1">Password</label>
            <asp:TextBox ID="txtPasword" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mt-5">
            
            <asp:Button ID="sendData" OnClick="sendData_Click" CssClass="btn btn-primary mt-5 mb-5 w-100 bg-color-primary-button" runat="server" Text="INGRESAR" />
            <hr class="mb-5" />
        </div>
        <div class="alert alert-danger form-text font-weight-light opacity-0" role="alert" runat="server" id="error">
            A simple danger alert—check it out!
        </div>

    </div>

</asp:Content>

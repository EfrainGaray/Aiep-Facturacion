<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="capaPresentacion.CrearFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-4 bg-white border-radius-10 p-3 ">
        <div class="row mt-3">
            <div class="col-8 text-center">
                <img src="Imagen/Grupo 1566@2x.png" class="logo-empresa" />
                <h1 class="mt-5 fs-26">PALERMO ELECTRONICS LTDA.</h1>
                <p class="mt-5 fs-22">Giro: Venta de artículos electrónicos etc.</p>
                <p class="mt-5">Fono:+56912345678.</p>
            </div>
            <div class="col-4">
                <div class="factura-folio text-center p-2 mt-3">
                    <p>R.U.T:<span>12.345.678-9</span> </p>
                    <p class="font-weight-bold">FACTURA ELECTRONICA</p>
                    <p>N° :1234</p>
                </div>
                <div class="text-center">
                    <p>S.I.I Santiago</p>
                    <p>Santiago,10 Noviembre 2020</p>

                </div>

            </div>
            <div class="container bg-gray p-3">

                <div class="form-row">
                    <label for="txtNombre" class="col-2 col-form-label">Señor(ra)</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtNombre" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                     <label for="txtTelefono" class="col-2 col-form-label">Telefono</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtTelefono" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="txtRut" class="col-2 col-form-label">Rut</label>
                    <div class="col-4">
                       <asp:TextBox ID="txtRut" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                     <label for="txtEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtEmail" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="txtComuna" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                       <asp:TextBox ID="txtComuna" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                     <label for="txtCondDePago" class="col-2 col-form-label">Cond. de Pago</label>
                    <div class="col-4">
                       <asp:TextBox ID="txtCondDePago" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                </div>


                <div class="form-row mt-3">
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                      <asp:TextBox ID="TextBox7" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <asp:TextBox ID="TextBox8" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-row mt-3">
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <asp:TextBox ID="TextBox9" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                     <asp:TextBox ID="TextBox10" CssClass="form-contro" runat="server"></asp:TextBox>
                    </div>
                </div>



            </div>
             <div class="container form-footer text-right mt-3">
                 <asp:Button ID="enviarFactura1" runat="server" CssClass="btn btn-info display-1" OnClick="Button1_Click" Text="Button" />
                </div>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="capaPresentacion.CrearFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-4 bg-white border-radius-10 ">
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
            </div>
            <div class="container bg-gray p-3">

                <div class="form-row">
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="First name">
                    </div>
                     <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="Last name">
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="First name">
                    </div>
                     <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="Last name">
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="First name">
                    </div>
                     <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="Last name">
                    </div>
                </div>


                  <div class="form-row mt-3">
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="First name">
                    </div>
                     <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="Last name">
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="First name">
                    </div>
                     <label for="staticEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <input type="text" class="form-control" placeholder="Last name">
                    </div>
                </div>
                
               

            </div>
             <div class="container form-footer text-right mt-3">
                 <asp:Button ID="enviarFactura1" runat="server" CssClass="btn btn-info display-1" OnClick="Button1_Click" Text="Button" />
                </div>
        </div>
        </div>
</asp:Content>

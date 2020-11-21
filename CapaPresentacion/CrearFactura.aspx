
<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="capaPresentacion.CrearFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="container-fluid mt-4 bg-white border-radius-10 ">
        <div class="row mt-3">
            <div class="col-8 text-center">
                <img src="Imagen/Grupo 1566@2x.png" class="logo-empresa" />
                <h1 class="mt-5 fs-26" runat="server" id="nombreEmpresa"></h1>
                <p class="mt-5 fs-22">Giro: <span runat="server" id="giro"> </span></p>
                <p class="mt-5">Fono:<span runat="server" id="fono"> </span></p>
            </div>
            <div class="col-4">
                <div class="factura-folio text-center p-2 mt-3">
                    <p>R.U.T:<span runat="server" id="rut">12.345.678-9</span> </p>
                    <p class="font-weight-bold">FACTURA ELECTRONICA</p>
                    <p>N° :<span runat="server" id="txtFolio"> </span></p>
                </div>
                <div class="text-center">
                    <p>S.I.I Santiago</p>
                    <p runat="server" id="fecha"></p>

                </div>

            </div>
            <div class="container bg-gray p-3">

                <div class="form-row">
                    <label for="txtNombre" class="col-2 col-form-label">Señor(ra)</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <label for="txtTelefono" class="col-2 col-form-label">Telefono</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="txtRut" class="col-2 col-form-label">Rut</label>
                    <div class="col-4">
                       <asp:TextBox ID="txtRut" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <label for="txtEmail" class="col-2 col-form-label">Email</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-row mt-3">
                     <label for="txtCondPago" class="col-2 col-form-label">Cond. de Pago</label>
                    <div class="col-4">
                       <asp:TextBox ID="txtCondPago" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>


                  <div class="form-row mt-3">
                    <label for="txtDireccion" class="col-2 col-form-label">Dirección</label>
                    <div class="col-4">
                      <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     
                </div>

                



            </div>
             <div class="container form-footer text-right mt-3 mb-3">
                 <asp:Button ID="enviarFactura1" runat="server" CssClass="btn btn-info display-1 cerrarColor" OnClick="Button1_Click" Text="Siguiente" />
                </div>
        </div>
        </div>
        </form>
</asp:Content>

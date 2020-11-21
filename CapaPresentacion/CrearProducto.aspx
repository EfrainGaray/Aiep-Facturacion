<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="CrearProducto.aspx.cs" Inherits="capaPresentacion.CrearProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form id="form1" runat="server">
    <div class="container-fluid mt-4 bg-white border-radius-10 ">
        <div class="row ">
            <div class="container bg-gray p-3  mt-5">

                <div class="form-row">
                    <label for="txtNombrePro" class="col-2 col-form-label">Nombre</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtNombrePro" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <label for="txtCodigoPro" class="col-2 col-form-label">Código</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtCodigoPro" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="txtStockPro" class="col-2 col-form-label">Stock</label>
                    <div class="col-4">
                       <asp:TextBox ID="txtStockPro" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <label for="txtDescripcionPro" class="col-2 col-form-label">Descripción</label>
                    <div class="col-4">
                        <asp:TextBox ID="txtDescripcionPro" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-row mt-3">
                    <label for="txtPrecioPro" class="col-2 col-form-label">Precio Unitario</label>
                    <div class="col-4">
                       <asp:TextBox ID="txtPrecioPro" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                   
                </div>

            </div>
             <div class="container form-footer text-right mt-3 mb-3">
                 <asp:Button ID="enviarProducto" runat="server" CssClass="btn btn-info display-1 cerrarColor" OnClick="enviarProducto_Click" Text="Guardar" />
                </div>
        </div>
        </div>
        </form>
</asp:Content>

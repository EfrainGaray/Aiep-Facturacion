<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="detalleFactura.aspx.cs" Inherits="capaPresentacion.detalleFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container-fluid mt-4 bg-green border-radius-10 p-3 ">
            <div class="row mt-3">
                <div class="col-8 text-center ">
                    <img src="Imagen/Grupo 1566@2x.png" class="logo-empresa" />
                    <h1 class="mt-5 fs-26" runat="server"  id="nombreEmpresa">PALERMO ELECTRONICS LTDA.</h1>
                    <p class="mt-5 fs-22">Giro: <span runat="server" id="giro">Venta de artículos electrónicos etc.</span></p>
                    <p class="mt-5">Fono:<span runat="server" id="telefono"></span></p>
                </div>
                <div class="col-4">
                    <div class="factura-folio text-center p-2 mt-3 bg-gray">
                        <p>R.U.T:<span>12.345.678-9</span> </p>
                        <p class="font-weight-bold">FACTURA ELECTRONICA</p>
                        <p>N° : <span runat="server" id="folioh"> </span></p>
                    </div>
                    <div class="text-center">
                        <p>S.I.I Santiago</p>
                        <p runat="server" id="fecha"></p>

                    </div>

                </div>
                <div class="container bg-gray p-3">

                    <div class="form-row">
                        <label for="staticEmail" class="col-2 col-form-label">Señor(es):</label>
                        <div class="col-4">
                            <asp:TextBox ID="txtSeñor" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <label for="staticEmail" class="col-2 col-form-label">Telefono:</label>
                        <div class="col-4">
                            <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-row mt-3">
                        <label for="staticEmail" class="col-2 col -form-label">R.U.T:</label>
                        <div class="col-4">
                            <asp:TextBox ID="txtRut" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <label for="staticEmail" class="col-2 col-form-label">E-mail:</label>
                        <div class="col-4">
                            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row mt-3">
                        <label for="staticEmail" class="col-2 col-form-label">Comuna:</label>
                        <div class="col-4">

                            <asp:TextBox ID="txtComuna" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <label for="staticEmail" class="col-2 col-form-label">Cond. de Pago</label>
                        <div class="col-4">
                            <asp:TextBox ID="txtPago" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>


                    <div class="form-row mt-3">
                        <label for="staticEmail" class="col-2 col-form-label">Ciudad:</label>
                        <div class="col-4">
                            <asp:TextBox ID="txtCuidad" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <label for="staticEmail" class="col-2 col-form-label">Direccion:</label>
                        <div class="col-4">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <label for="staticEmail" class="col-2 col-form-label">Giro:</label>
                        <div class="col-4">
                            <br />
                            <asp:TextBox ID="txtGiro" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>


                </div>
            </div>
        </div>
        <div class="container-fluid mt-4 bg-white border-radius-10 p-3 ">
            <h2>Cargar Producto</h2>
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <span class="input-group-text" id="basic-addon1">
                        <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-search" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" d="M10.442 10.442a1 1 0 0 1 1.415 0l3.85 3.85a1 1 0 0 1-1.414 1.415l-3.85-3.85a1 1 0 0 1 0-1.415z" />
                            <path fill-rule="evenodd" d="M6.5 12a5.5 5.5 0 1 0 0-11 5.5 5.5 0 0 0 0 11zM13 6.5a6.5 6.5 0 1 1-13 0 6.5 6.5 0 0 1 13 0z" />
                        </svg>

                    </span>
                </div>
                <input type="text" class="form-control" placeholder="Buscar Producto" aria-label="Productos" aria-describedby="basic-addon1">
            </div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-dark">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="lbID" runat="server" Text='<% #Bind("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Codigo">
                        <ItemTemplate>
                            <asp:Label ID="lbCodigo" runat="server" Text='<% #Bind("Codigo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre Producto">
                        <ItemTemplate>
                            <asp:Label ID="lbProducto" runat="server" Text='<% #Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Descripcion ">
                        <ItemTemplate>
                            <asp:Label ID="lbDescripcion" runat="server" Text='<% #Bind("Descripcion") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cantidad">
                        <ItemTemplate>
                            <asp:Label ID="lbCantidad" runat="server" Text='<% #Bind("Cantidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio">
                        <ItemTemplate>
                            <asp:Label ID="lbTotal" runat="server" Text='<% #Bind("Precio") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <div class="row">
                <div class="input-group col-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Observación:</span>

                    </div>
                    <textarea class="form-control" aria-label="With textarea"></textarea>
                </div>
                <div class="form-row mt-3 col-8 text-right">
                    <label for="staticEmail" class="col-4 col-form-label">Neto $ :</label>
                    <div class="col-8">
                        <asp:TextBox ID="txtNeto" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <label for="staticEmail" class="col-4 col-form-label">I.V.A $ :</label>
                    <div class="col-8">
                        <asp:TextBox ID="txtIva" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <label for="staticEmail" class="col-4 col-form-label">Total $ :</label>
                    <div class="col-8">
                        <asp:TextBox ID="txtTotal" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                </div>

            </div>

            <div class="container form-footer text-right mt-3">
                <asp:Button ID="Button1" CssClass="btn cerrarColor display-1" runat="server" Text="AGREGAR FACTURA" />
            </div>




        </div>






    </form>


</asp:Content>

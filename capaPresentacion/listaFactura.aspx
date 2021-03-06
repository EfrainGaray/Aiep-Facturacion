﻿<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="listaFactura.aspx.cs" Inherits="capaPresentacion.listaFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <h1>Facturas creadas por el usuario: <span runat="server" id="nombreUsuario"></span></h1>
        <hr />
        <div class="row">
            <div class="col-8 "></div>
            <div class="col-4 text-right">
                <a href="CrearFactura.aspx" class="fs-24 mr-4 " title="Crear Factura" tabindex="-1" role="button" aria-disabled="true">
                    <svg width="40" stroke="#FF007C" viewBox="0 0 16 16" class="bi bi-plus-circle" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                        <path fill-rule="evenodd" d="M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z" />
                        <path fill-rule="evenodd" d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z" />
                    </svg></a>
            </div>
        </div>
        <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-dark">
            <Columns>
                <asp:TemplateField HeaderText="Folio">
                    <ItemTemplate>
                        <asp:Label ID="lbFolio" runat="server" Text='<% #Bind("Folio") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="RutEmpresa">
                    <ItemTemplate>
                        <asp:Label ID="lbRutEmpresa" runat="server" Text='<% #Bind("RutEmpresa") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Razon Social">
                    <ItemTemplate>
                        <asp:Label ID="lbRazonSocial" runat="server" Text='<% #Bind("RazonSocial") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="RUT Cliente">
                    <ItemTemplate>
                        <asp:Label ID="lbRutCliente" runat="server" Text='<% #Bind("RutCliente") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre Cliente">
                    <ItemTemplate>
                        <asp:Label ID="lbNombreCliente" runat="server" Text='<% #Bind("NombreCliente") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total">
                    <ItemTemplate>
                        <asp:Label ID="lbTotal" runat="server" Text='<% #Bind("Total") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IVA">
                    <ItemTemplate>
                        <asp:Label ID="lbIVA" runat="server" Text='<% #Bind("IVA") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Estado">
                    <ItemTemplate>
                        <asp:Label ID="lbEstado" runat="server" Text='<% #Bind("Estado") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Herramientas">
                    <ItemTemplate>
                
                         <asp:LinkButton ID="editar" runat="server" OnClick="editar_Click" CssClass="" data-folio='<%# Eval("Folio") %>'  data-estado='<%# Eval("Estado") %>'>
                            <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-pen" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                <path fill-rule="evenodd" d="M13.498.795l.149-.149a1.207 1.207 0 1 1 1.707 1.708l-.149.148a1.5 1.5 0 0 1-.059 2.059L4.854 14.854a.5.5 0 0 1-.233.131l-4 1a.5.5 0 0 1-.606-.606l1-4a.5.5 0 0 1 .131-.232l9.642-9.642a.5.5 0 0 0-.642.056L6.854 4.854a.5.5 0 1 1-.708-.708L9.44.854A1.5 1.5 0 0 1 11.5.796a1.5 1.5 0 0 1 1.998-.001zm-.644.766a.5.5 0 0 0-.707 0L1.95 11.756l-.764 3.057 3.057-.764L14.44 3.854a.5.5 0 0 0 0-.708l-1.585-1.585z" />
                            </svg>
                          </asp:LinkButton>

                        <asp:LinkButton ID="Borrar" runat="server" OnClick="Borrar_Click" CssClass="" data-folio='<%# Eval("Folio") %>'>
                        <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-trash" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                            <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z" />
                            <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z" />
                        </svg>
                        </asp:LinkButton>

                    </ItemTemplate>

                </asp:TemplateField>
            </Columns>

        </asp:GridView>
    </form>
</asp:Content>

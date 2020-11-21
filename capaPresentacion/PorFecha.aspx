<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="PorFecha.aspx.cs" Inherits="capaPresentacion.PorFecha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <h1>Facturas</h1>
        <hr />
        <div class="row text-white">
            <div class="col-4 text-right">
                <label>Fecha Inicial:</label>
                <asp:TextBox ID="txtFInicial" runat="server" TextMode="DateTime" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-4 text-left">


                <label>Fecha Final:</label>
                <asp:TextBox ID="txtFFinal" runat="server" TextMode="DateTime" CssClass="form-control"></asp:TextBox>
            
            </div>
            <div class="col-2 mt-4">
                <asp:LinkButton ID="buscarxFecha" runat="server" OnClick="buscarxFecha_Click" CssClass="">
                        <svg width="2em" height="2em" viewBox="0 0 16 16" class="bi bi-search" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                        <path fill-rule="evenodd" d="M10.442 10.442a1 1 0 0 1 1.415 0l3.85 3.85a1 1 0 0 1-1.414 1.415l-3.85-3.85a1 1 0 0 1 0-1.415z"/>
                        <path fill-rule="evenodd" d="M6.5 12a5.5 5.5 0 1 0 0-11 5.5 5.5 0 0 0 0 11zM13 6.5a6.5 6.5 0 1 1-13 0 6.5 6.5 0 0 1 13 0z"/>
                    </svg>
                </asp:LinkButton>
            </div>
        </div>
        <br />
        <asp:GridView ID="gvDocumentosFecha" runat="server" AutoGenerateColumns="false" CssClass="table table-dark">
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
                <asp:TemplateField HeaderText="Creada Por">
                     <ItemTemplate>
                        <asp:Label ID="lbCreadaPor" runat="server" Text='<% #Bind("CreadaPor") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>

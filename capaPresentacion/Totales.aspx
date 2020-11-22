<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.Master" AutoEventWireup="true" CodeBehind="Totales.aspx.cs" Inherits="capaPresentacion.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <h1>Facturas</h1>
        <hr />
        <asp:GridView ID="gvDocumentos" runat="server" AutoGenerateColumns="false" CssClass="table table-dark">
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
            
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>

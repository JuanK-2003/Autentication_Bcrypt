<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresoProducto.aspx.cs" Inherits="TiendaEnLinea.IngresoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ingreso de Productos</h1>
    <p>
        Codigo
        <asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
    </p>
    <p>
        Descripción
        <asp:TextBox ID="TextBoxDescripcion" runat="server"></asp:TextBox>
    </p>
    <p>
        Marca
        <asp:TextBox ID="TextBoxMarca" runat="server"></asp:TextBox>
    </p>
    <p>
        Existencia
        <asp:TextBox ID="TextBoxExistencia" runat="server"></asp:TextBox>
    </p>
    <p>
        Seleccione Imagen<asp:FileUpload ID="FileUploadImagen" runat="server" />
    </p>
    <p>
        <asp:Label ID="LabelEstado" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" Width="181px" />
    </p>
</asp:Content>

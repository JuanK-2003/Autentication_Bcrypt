<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TiendaEnLinea.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    &nbsp;</p>
<p>
    Nombre de Usuario
    <asp:TextBox ID="TextBoxUsuario" runat="server"></asp:TextBox>
</p>
<p>
    Password
    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    Nivel de acceso
    <asp:RadioButtonList ID="RadioButtonListNivel" runat="server">
        <asp:ListItem Value="1">Administrador</asp:ListItem>
        <asp:ListItem Value="2">Cliente</asp:ListItem>
    </asp:RadioButtonList>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" />
</p>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test2.aspx.cs" Inherits="WebApplication1.Test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Google" OnClick="Button1_Click" /></br>
    <asp:Label ID="Label1" runat="server"></asp:Label></br>
    <asp:Label ID="Label2" runat="server" Text="帳號"></asp:Label>
    <asp:TextBox ID="user" runat="server"></asp:TextBox></br>
    <asp:Label ID="Label3" runat="server" Text="密碼"></asp:Label>
    <asp:TextBox ID="passwd" runat="server"></asp:TextBox></br>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="登入" />
</asp:Content>

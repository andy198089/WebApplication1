<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_image.aspx.cs" Inherits="WebApplication1.Login_image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" UseSubmitBehavior="False" />
            <asp:Label ID="Message" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" />
        </div>
    </form>
</body>
</html>

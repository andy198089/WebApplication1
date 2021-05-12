<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="WebApplication1.Test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Test1
            </br>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </br>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </br>
            <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" />
            </br>
            <input type="text" id="fname" name="user" value="">
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </br>
            <input type="text" id="fname" name="passwd" value="">
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </br>
            <input id="Submit1" type="submit" value="submit" />
            </br>
            <input type="text" id="fname" name="chatuser" value="root">
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            </br>
            <input type="text" id="fname" name="chatpasswd" value="">
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </br>
            <input type="text" id="fname" name="chatname" value="">
            </br>
            <asp:Button ID="Button2" runat="server" Text="登入聊天室" OnClick="Button2_Click" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="註冊" />
            </br>
            <asp:Button ID="Button3" runat="server" Text="Test_1" OnClick="Button3_Click" Height="24px" Width="62px" />
            </br>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button3_Click">LinkButton</asp:LinkButton>
            </br>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" Width="100px" />
            <br />
        </div>
    </form>
</body>
</html>

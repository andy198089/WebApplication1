<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatForm.aspx.cs" Inherits="WebApplication1.ChatForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ChatRoom" runat="server" Text="聊天室" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="login_count"></asp:Label>
            </br>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Height="279px" Width="369px" TextMode="MultiLine"></asp:TextBox>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:Timer ID="Timer1" runat="server" Interval="500" OnTick="Timer2_Tick">
            </asp:Timer>
            </br>
            <asp:TextBox ID="TextBox2" runat="server" Height="19px" Width="369px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="送出" OnClick="Button2_Click" />
            </br>
            <asp:Button ID="Button1" runat="server" Text="登出" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        </div>
    </form>
</body>
</html>

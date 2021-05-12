<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="game1.aspx.cs" Inherits="WebApplication1.game1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="剪刀石頭布" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>            
            </br>
            <asp:Label ID="Label2" runat="server" Text="電腦出: "></asp:Label>
            </br>
            <asp:Image ID="Image1" runat="server" />
            </br>
            <asp:Label ID="Label3" runat="server" Text="玩家出: "></asp:Label>
            </br>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/paper.png" OnClick="ImageButton1_Click" />
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/sicer.png" OnClick="ImageButton2_Click" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/stone.png" OnClick="ImageButton3_Click" />
            </br>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            </br>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            </br>
            <asp:Button ID="Button1" runat="server" Text="登出" OnClick="Button1_Click" />            
            </br>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick1" Interval="1000"></asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>

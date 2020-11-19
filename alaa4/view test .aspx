<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view test .aspx.cs" Inherits="alaa4.view_test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
                <asp:View ID="View1" runat="server">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="go" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="show" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>

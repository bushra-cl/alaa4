<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="alaa4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          الاسم  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>

           المهنه <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br>
            <asp:Button ID="Button1" runat="server" Text="test session" OnClick="Button1_Click" />
            <br />
            <br />
         اسم الاب<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br>
           العائله <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br>
            <asp:Button ID="Button2" runat="server" Text="test application" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>

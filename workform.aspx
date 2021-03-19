<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="workform.aspx.cs" Inherits="Homework_week2.workform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        ID:<asp:TextBox ID="textID" runat="server"></asp:TextBox><br />
        Name:<asp:TextBox ID="textName" runat="server"></asp:TextBox><br />
        Birthday:<asp:TextBox ID="textBir" runat="server"></asp:TextBox><br />
        Color:<asp:TextBox ID="textcol" runat="server"></asp:TextBox><br />
        <asp:Button ID="B_Insert" runat="server" Text="Insert" OnClick="Insert" />&nbsp;&nbsp;&nbsp;
        <asp:Button ID="B_Delete" runat="server" Text="Delete" OnClick="Delete"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="B_Updata" runat="server" Text="Updata" OnClick="Updata"/>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="B_Read" runat="server" Text="Read" OnClick="Read"/><br /><br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>

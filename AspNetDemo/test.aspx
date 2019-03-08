<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="AspNetDemo.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Value" runat="server" />
            <asp:TextBox runat="server" ID="tbTest" />
        </div>
        <asp:Button Text="text" runat="server" OnClick="Test_Click" />
        <h1><%= Application["value"] %></h1>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list2.aspx.cs" Inherits="AspNetDemo.list2" %>

<%@ Import Namespace="AspNetDemo.Models" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:Label Text="Value" runat="server" />
            <asp:TextBox runat="server" ID="tbTest" />
        </div>
        <asp:Button Text="Submit" runat="server" OnClick="Test_Click" />
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <asp:GridView runat="server" ID="ProductsGrid"
                        ItemType="AspNetDemo.Models.Product" DataKeyNames="Id"
                        SelectMethod="productsGrid_GetData"
                        AutoGenerateColumns="False"
                        AllowPaging="True" AllowSorting="True" AutoGenerateEditButton="True">
                        <Columns>
                            <asp:DynamicField DataField="Id" />
                            <asp:DynamicField DataField="Name" />
                            <asp:DynamicField DataField="Price" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
    <div class="row">
        <div class="col-md-12">
            <table class="table table-bordered table-stripped">
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>#</th>
                </tr>
                <% foreach (Product product in (IList)Application["products"])
                    { %>
                <tr>
                    <td><%= product.Id %></td>
                    <td><%= product.Name %></td>
                    <td><%= product.Price %></td>
                    <td>
                        <button class="btn btn-primary">View</button></td>
                </tr>
                <% } %>
            </table>
        </div>
    </div>
</body>
</html>

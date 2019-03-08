<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="AspNetDemo.ProductsList" %>

<%@ Import Namespace="AspNetDemo.Models" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
</head>
<body>
    <div class="container">

        <form id="form3" runat="server">
        <div>
            <asp:Label Text="Value" runat="server" />
            <asp:TextBox runat="server" ID="tbTest" />
        </div>
        <asp:Button Text="text" runat="server" OnClick="Test_Click" />

            
    </form>
        <div class="row">
            <div class="col-md-12">
                <%--<table class="table table-bordered table-stripped">
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
                        <td><button class="btn btn-primary">View</button></td>
                    </tr>
                    <% } %>
                </table>--%>
            </div>
        </div>
    
    </div>
    <!--
        <div class="container">
        <div class="row">
            <div class="col-md-12">
                <form runat="server" >

                    <asp:GridView runat="server" ID="ProductsGrid"  
                        ItemType="AspNetDemo.Models.Product" DataKeyNames="Id"  
                        SelectMethod="productsGrid_GetData"  
                        AutoGenerateColumns="false" CssClass="table table-bordered table-stripped">  

                    <Columns>  
                        <asp:DynamicField DataField="Id"/>  
                        <asp:DynamicField DataField="Name"/>  
                        <asp:DynamicField DataField="Price"/>  
                </Columns>  
                </asp:GridView> 

                </form>
                

            </div>
        </div>
    </div>-->

</body>
</html>

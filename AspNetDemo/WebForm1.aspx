<%@ Page Language="C#" AutoEventWireup="true" 
         CodeBehind="WebForm1.aspx.cs" 
         Inherits="AspNetDemo.WebForm1"%>
<%@ Import Namespace="System.Collections.Generic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <% for (int i = 0; i < 3; i++) { %>
        <div>
            Hello World - <% Response.Write(i + 1); %><br />
        </div>
        <% } %>
        <div>Date is <%= DateTime.Now.ToString() %></div>
        
        <asp:Label ID="lblName" runat="server" />
        <br /><br /><br /><br /><br /><br />

        <%-- Data Binding --%>
        <asp:DropDownList ID="CountryList" runat="server">
            <asp:ListItem>MA</asp:ListItem>
            <asp:ListItem>US</asp:ListItem>
            <asp:ListItem>UK</asp:ListItem>
        </asp:DropDownList>
        <asp:Button Text="Submit" OnClick="SubmitBtn_Click" runat="server" />
        <p>
            Selected State:
            <asp:Label Text='<%# CountryList.SelectedItem.Text %>' 
                runat="server" />
        </p>


    <script runat="server">  
        void SubmitBtn_Click(Object sender, EventArgs e) {
            Page.DataBind();
        }
    </script>

        <asp:Button Text="text" runat="server" OnClick="btnSubmit_Click" />
    </form>

    </body>
</html>

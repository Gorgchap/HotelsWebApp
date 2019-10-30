<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersPage.aspx.cs" Inherits="WebApp.UsersPage" %>
<%@ Register Src="~/Admin/AdminNavbar.ascx" TagName="AdminNavbar" TagPrefix="admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Hotels WebApp</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body style="background-color: cornflowerblue">
    <admin:AdminNavbar runat="server"/>
    <div style="margin-top: 4.5rem; padding: 0 1rem">
        <h2 class="text-center">List of users</h2>
        <div class="card">
            <asp:repeater runat="server" id="Users">
                <HeaderTemplate>
                    <table class="table table-hover text-center mb-0">
                    <tr>
                        <th>Login</th>
                        <th>Full name</th>
                        <th>Email address</th>
                        <th>Mobile phone</th>
                        <th><a href="AddUser.aspx" runat="server" class="text-success">New User</a></th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:label runat="server"><%# Eval("Login") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("Name") + " " + Eval("Surname") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("Email") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("Phone") %></asp:label></td>
                        <td class="font-weight-bold">
                            <a class="text-info mr-1" href="EditUser.aspx?id=<%# DataBinder.Eval(Container.DataItem, "Id") %>">Edit</a>
                            <a class="text-danger">Delete</a>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:repeater>
        </div>
    </div>
</body>
</html>

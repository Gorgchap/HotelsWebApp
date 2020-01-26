<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hotels.aspx.cs" Inherits="WebApp.Hotels" %>
<%@ Register Src="~/User/UserNavbar.ascx" TagName="UserNavbar" TagPrefix="user" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Hotels WebApp</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body style="background-color: cornflowerblue">
    <user:UserNavbar runat="server"/>
    <div style="margin-top: 4.5rem; padding: 0 1rem">
        <h2 class="text-center">List of hotels</h2>
        <div class="card">
            <asp:repeater runat="server" id="Htls">
                <HeaderTemplate>
                    <table class="table table-hover text-center mb-0">
                    <tr>
                        <th>Наименование</th>
                        <th>Город</th>
                        <th>Адрес</th>
                        <th>Рейтинг</th>
                        <th>Номера</th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:label runat="server"><%# Eval("Name") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("City") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("Address") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("Rating") %></asp:label></td>
                        <td class="font-weight-bold">
                            <a class="text-info" href="Rooms.aspx?id=<%# DataBinder.Eval(Container.DataItem, "Id") %>">Список номеров</a>
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

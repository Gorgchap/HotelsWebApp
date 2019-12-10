<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="WebApp.Rooms" %>
<%@ Register Src="~/User/UserNavbar.ascx" TagName="UserNavbar" TagPrefix="user" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Hotels WebApp</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body style="background-color: cornflowerblue">
    <user:UserNavbar runat="server"/>
    <div style="margin-top: 4.5rem; padding: 0 1rem">
        <h2 class="text-center">Rooms</h2>
        <div class="card" style="width: 50%; margin: 0 auto">
            <asp:repeater runat="server" id="Rms">
                <HeaderTemplate>
                    <table class="table table-hover text-center mb-0">
                    <tr>
                        <th>Пор. номер</th>
                        <th>Цена (в сутки)</th>
                        <th>Тип номера</th>
                        <th>Действия</th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:label runat="server"><%# Eval("Number") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("Price") %></asp:label></td>
                        <td><asp:label runat="server"><%# Eval("RoomType") %></asp:label></td>
                        <td class="font-weight-bold">
                            <a class="text-info" href="#">Бронь</a>
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

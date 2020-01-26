<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HotelsPage.aspx.cs" Inherits="WebApp.HotelsPage" %>
<%@ Register Src="~/Admin/AdminNavbar.ascx" TagName="AdminNavbar" TagPrefix="admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Hotels WebApp</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="frontend/jquery.tmpl.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body style="background-color: cornflowerblue">
    <admin:AdminNavbar runat="server"/>
    <div style="margin-top: 4.5rem; padding: 0 1rem">
        <h2 class="text-center">List of hotels</h2>
        <div class="card" id="results">
            <table class="table table-hover text-center mb-0">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>City</th>
                        <th>Address</th>
                        <th>Rating</th>
                        <th><a class="text-success">Add new</a></th>
                    </tr>
                </thead>
                <tbody></tbody>
            </table>
            <div id="paginator" class="d-flex justify-content-center"></div>
        </div>
        <div id="edit" class="mt-3 col-6 offset-3 col-md-4 offset-md-4"></div>
    </div>
    <script src="./frontend/hotels.js"></script>
</body>
</html>

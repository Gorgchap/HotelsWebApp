<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="WebApp.EditUser" %>
<%@ Register Src="~/Admin/AdminNavbar.ascx" TagName="AdminNavbar" TagPrefix="admin" %>
<%@ Register Src="~/UserDataControl.ascx" TagName="UserDataControl" TagPrefix="user" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hotels WebApp</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body style="background-color: cornflowerblue">
    <admin:AdminNavbar runat="server"/>
    <div style="margin-top: 4.5rem; padding: 0 1rem">
        <div class="row">
            <div class="col-10 offset-1 col-sm-8 offset-sm-2 col-md-6 offset-md-3 col-lg-4 offset-lg-4">
                <form runat="server" class="card p-3">
                    <user:UserDataControl ID="Data" runat="server"/>
                    <div class="mt-3" style="display: flex; justify-content: center; align-items: center">
                        <asp:Button runat="server" ID="Save" Text="Save" CssClass="btn btn-primary"/>
                        <asp:Label ID="Output" runat="server" CssClass="ml-3"/>
                    </div>
                </form>
            </div>
       </div>
    </div>
</body>
</html>

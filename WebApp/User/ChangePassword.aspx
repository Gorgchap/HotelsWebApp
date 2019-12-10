<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebApp.ChangePassword" %>
<%@ Register Src="~/User/UserNavbar.ascx" TagName="UserNavbar" TagPrefix="user" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <title>Hotels WebApp</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body style="background-color: cornflowerblue">
    <user:UserNavbar runat="server"/>
    <div style="margin-top: 4.5rem; padding: 0 1rem">
        <h2 class="text-center">Change password</h2>
        <div class="row">
            <div class="col-10 offset-1 col-sm-8 offset-sm-2 col-md-6 offset-md-3 col-lg-4 offset-lg-4">
                <form runat="server" class="card p-3">
                    <label class="mb-0">Current password</label>
                    <asp:TextBox runat="server" ID="CurPwd" CssClass="form-control mx-auto" TextMode="Password"/>
                    <label class="mt-3 mb-0">New password</label>
		            <asp:TextBox runat="server" ID="NewPwd" CssClass="form-control mx-auto" TextMode="Password"/>
                    <label class="mt-3 mb-0">Confirm new password</label>
		            <asp:TextBox runat="server" ID="NewPwd2" CssClass="form-control mx-auto" TextMode="Password"/>
                    <div class="mt-3" style="display: flex; justify-content: center; align-items: center">
                        <asp:Button runat="server" ID="Submit" Text="Change" CssClass="btn btn-primary"/>
                        <asp:Label ID="Output" runat="server" CssClass="ml-3"/>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>

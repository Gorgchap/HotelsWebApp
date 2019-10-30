<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Hotels WebApp</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body style="background-color: cornflowerblue">
    <div class="row">
        <div class="col-10 offset-1 col-sm-8 offset-sm-2 col-md-6 offset-md-3 col-lg-4 offset-lg-4">
            <p class="display-4 text-center font-weight-bold my-5 mx-auto" style="width: 100%">Hotels</p>
            <form runat="server" class="card p-3">
                <label class="mb-0">Login</label>
                <asp:TextBox runat="server" ID="LogIn" CssClass="form-control mx-auto"/>
                <label class="mt-3 mb-0">Password</label>
		        <asp:TextBox runat="server" ID="Password" CssClass="form-control mx-auto" TextMode="Password"/>
                <div class="mt-3" style="display: flex; justify-content: center; align-items: center">
                    <asp:Button runat="server" ID="Submit" Text="Sign in" CssClass="btn btn-primary"/>
                    <asp:LinkButton runat="server" ID="Register" Text="Not registered yet?" CssClass="ml-3"/>
                </div>
                <asp:Label ID="Output" runat="server" CssClass="mx-auto"/>
            </form>
        </div>
    </div>
</body>
</html>

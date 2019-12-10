<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Hotels WebApp</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body style="background-color: cornflowerblue">
    <div class="row">
        <div class="col-10 offset-1 col-sm-8 offset-sm-2 col-lg-6 offset-lg-3">
            <p class="display-4 text-center font-weight-bold my-5 mx-auto" style="width: 100%">Register</p>
            <form runat="server" class="card p-3">
                <div class="row">
                    <div class="col-sm-6">
                        <label class="mb-0">Login</label>
                        <asp:TextBox runat="server" ID="LogIn" placeholder="From 1 to 100 symbols" CssClass="form-control mx-auto"/>
                        <label class="mb-0 mt-2">Name</label>
                        <asp:TextBox runat="server" ID="Name" placeholder="From 1 to 30 symbols" CssClass="form-control mx-auto"/>
                        <label class="mb-0 mt-2">Surname</label>
		                <asp:TextBox runat="server" ID="Surname" placeholder="From 1 to 30 symbols" CssClass="form-control mx-auto"/>
                        <label class="mb-0 mt-2">Email</label>
                        <asp:TextBox runat="server" ID="Email" placeholder="Email address" CssClass="form-control mx-auto"/>
                    </div>
                    <div class="col-sm-6">
                        <label class="mb-0">Phone</label>
                        <asp:TextBox runat="server" ID="Phone" placeholder="Phone number" CssClass="form-control mx-auto"/>
                        <label class="mb-0 mt-2">Password</label>
                        <asp:TextBox runat="server" ID="Pwd" CssClass="form-control mx-auto" placeholder="One symbol at least" TextMode="Password"/>
                        <label class="mb-0 mt-2">Confirm password</label>
		                <asp:TextBox runat="server" ID="Pwd2" CssClass="form-control mx-auto" placeholder="Must be equal to password" TextMode="Password"/>
                        <div class="mt-3" style="display: flex; justify-content: center; align-items: center">
                            <asp:Button runat="server" ID="Submit" Text="Register" CssClass="btn btn-primary"/>
                            <asp:LinkButton runat="server" ID="LoginPage" Text="Already registered?" CssClass="ml-3"/>
                        </div>
                    </div>
                </div>
                <asp:Label ID="Output" runat="server" CssClass="mx-auto"/>
            </form>
        </div>
    </div>
</body>
</html>
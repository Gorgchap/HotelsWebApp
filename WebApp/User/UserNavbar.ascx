<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserNavbar.ascx.cs" Inherits="WebApp.UserNavbar" %>
<nav class="navbar navbar-expand bg-dark navbar-dark fixed-top">
    <a class="navbar-brand" href="#">Hotels</a>
    <ul class="navbar-nav ml-auto">
        <li class="nav-item">
            <a class="nav-link dropdown-toggle" href="#" data-toggle="dropdown">Actions</a>
            <div class="dropdown-menu dropdown-menu-right bg-dark" style="margin-top: -0.75rem">
                <a class="dropdown-item text-white" onmouseover="this.style.background='#5f6a75'" onmouseout="this.style.background='#343a40'" href="ChangePassword.aspx">Change pwd</a>
                <a class="dropdown-item text-white" onmouseover="this.style.background='#5f6a75'" onmouseout="this.style.background='#343a40'" href="../Login.aspx?logout=true">Sign out</a>
            </div>
        </li>
    </ul>
</nav>
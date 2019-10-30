<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminNavbar.ascx.cs" Inherits="WebApp.AdminNavbar" %>
<nav class="navbar navbar-expand bg-dark navbar-dark fixed-top">
    <a class="navbar-brand mr-auto" href="#">Hotels</a>
    <ul class="navbar-nav">
        <li class="nav-item">
            <a class="nav-link" href="UsersPage.aspx">Users</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="HotelsPage.aspx">Hotels</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="BookingsPage.aspx">Bookings</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="../Login.aspx?logout=true">Sign out</a>
        </li>
    </ul>
</nav>
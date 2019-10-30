<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserDataControl.ascx.cs" Inherits="WebApp.UserDataControl" %>
<label class="mb-0">Login</label>
<asp:TextBox runat="server" placeholder="From 1 to 100 symbols" ID ="TextLogin"></asp:TextBox>
<label class="mb-0 mt-3">Name</label>
<asp:TextBox runat="server" placeholder="From 1 to 30 symbols" ID ="TextName"></asp:TextBox>
<label class="mb-0 mt-3">Surname</label>
<asp:TextBox runat="server" placeholder="From 1 to 30 symbols" ID ="TextSurname"></asp:TextBox>
<label class="mb-0 mt-3">Email</label>
<asp:TextBox runat="server" placeholder="Email address" ID ="TextEmail"></asp:TextBox>
<label class="mb-0 mt-3">Phone</label>
<asp:TextBox runat="server" placeholder="Phone number" ID ="TextPhone"></asp:TextBox>
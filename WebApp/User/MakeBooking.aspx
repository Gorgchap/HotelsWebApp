<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeBooking.aspx.cs" Inherits="WebApp.MakeBooking" %>
<%@ Register Src="~/User/UserNavbar.ascx" TagName="UserNavbar" TagPrefix="user" %>
<%@ Register Assembly="WebApp" Namespace="WebApp" TagPrefix="bk" %>

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
    <script src="https://momentjs.com/downloads/moment.js" type="text/javascript"></script>
</head>
<body style="background-color: cornflowerblue">
    <user:UserNavbar runat="server"/>
    <div style="margin-top: 4.5rem; padding: 0 1rem">
        <div class="row">
            <div class="col-10 offset-1 col-sm-8 offset-sm-2 col-md-6 offset-md-3 col-lg-4 offset-lg-4">
                <h2 class="text-center">Dates of booking</h2>
                <form runat="server" class="card p-3">
                    <bk:BookingDates ID="Data" runat="server"/>
                    <asp:Button runat="server" ID="Save" Text="Сохранить" CssClass="btn btn-primary mx-auto mt-3"/>
                </form>
            </div>
       </div>
    </div>
    <script type="text/javascript">
        const begin = document.getElementById("begin"), end = document.getElementById("end");
        isInvalid = str => {
            const arr = str.split('.');
            if (/[^\d.]/.test(str) || arr.length !== 3 || arr.some(x => x === '') ||
                ![1, 2].includes(arr[0].length) || ![1, 2].includes(arr[1].length) || ![2, 4].includes(arr[2].length) ||
                (arr[2].length === 2 && moment(str, "DD.MM.YYYY").isAfter(moment("01.01.2050", "DD.MM.YYYY"))) ||
                !moment(str, "DD.MM.YYYY")._isValid) {
                return true;
            }
            return false;
        }
        viceVersa = () => moment(begin.value, "DD.MM.YYYY").isAfter(moment(end.value, "DD.MM.YYYY"));
        $("#begin").on("input", e => {
            begin.style.backgroundColor = isInvalid(e.target.value) || isInvalid(end.value)
                ? '#ff4444' : viceVersa() ? '#e1ff00' : '#77ff99';
            end.style.backgroundColor = isInvalid(e.target.value) || isInvalid(end.value)
                ? '#ff4444' : viceVersa() ? '#e1ff00' : '#77ff99';
        });
        $("#end").on("input", e => {
            begin.style.backgroundColor = isInvalid(e.target.value) || isInvalid(begin.value)
                ? '#ff4444' : viceVersa() ? '#e1ff00' : '#77ff99';
            end.style.backgroundColor = isInvalid(e.target.value) || isInvalid(begin.value)
                ? '#ff4444' : viceVersa() ? '#e1ff00' : '#77ff99';
        });
    </script>
</body>
</html>

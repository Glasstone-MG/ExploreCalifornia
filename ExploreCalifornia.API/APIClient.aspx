<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APIClient.aspx.cs" Inherits="ExploreCalifornia.API.APIClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="TourDisplay">
    </div>
    </form>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script>
        $(function () {
            $.getJSON("/api/Tours").done(function (data) {
                $.each(data, function (index, tour) {
                    for (prop in tour) {
                        $('#TourDisplay').append(prop + ": " + tour[prop] + "<br/>");
                    }
                    $('#TourDisplay').append("<br/>");
                });
            });
        });
    </script>
</body>
</html>

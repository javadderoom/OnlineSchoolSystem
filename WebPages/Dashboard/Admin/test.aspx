<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebPages.Dashboard.Admin.test" %>

<%@ Register Src="~/Dashboard/Controllers/HighChartsControl.ascx" TagPrefix="hc" TagName="Chart" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../HighCharts/exporting.js"></script>
    <script src="../HighCharts/highcharts.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <hc:Chart runat="server"></hc:Chart>
        </div>
    </form>
</body>
</html>

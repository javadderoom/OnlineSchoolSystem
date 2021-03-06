﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeChart.aspx.cs" Inherits="WebPages.Dashboard.Admin.GradeChart" %>

<%@ Register Src="~/Controllers/GradeChartController.ascx" TagPrefix="hc" TagName="GradeChartController" %>

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
            <hc:GradeChartController runat="server" id="GradeChartController" />
        </div>
    </form>
</body>
</html>
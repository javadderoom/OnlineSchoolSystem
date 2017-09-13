<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeChart.aspx.cs" Inherits="WebPages.Dashboard.Admin.GradeChart" %>

<%--<%@ Register Src="~/Controllers/HighChartsControl.ascx" TagPrefix="hc" TagName="HighCharts" %>--%>
<%@ Register Src="~/Dashboard/Controllers/GradeChart.ascx" TagPrefix="hc" TagName="GradeCharts" %>

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
            <%--<hc:HighCharts runat="server" ID="chart" />--%>
            <hc:GradeCharts runat="server" ID="GradeChart" />
        </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentChart.aspx.cs" Inherits="WebPages.Dashboard.Admin.StudentChart" %>

<%@ Register Src="~/Controllers/StudentChartController.ascx" TagPrefix="hc" TagName="StudentChartController" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <hc:StudentChartController runat="server" id="StudentChartController" />
        </div>
    </form>
</body>
</html>
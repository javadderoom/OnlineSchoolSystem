<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/Admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebPages.Dashboard.Admin.test" %>

<%@ Register Assembly="PrintControl" Namespace="PrintControl" TagPrefix="AmirPrint" %>

<%--<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>--%>

<%--<%@ Register Assembly="Telerik.ReportViewer.Html5.WebForms, Version=11.1.17.614, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.Html5.WebForms" TagPrefix="telerik" %>--%>

<%@ Register Src="~/Controllers/HighChartsControl.ascx" TagPrefix="hc" TagName="chart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <AmirPrint:Print ID="Print1" runat="server"></AmirPrint:Print>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <%--    <meta name="description" content="" />
    <meta name="author" content="" />--%>
    <link href="../Styles/bootstrap.css" rel="stylesheet" />
    <link href="../Styles/simple-sidebar.css" rel="stylesheet" />
    <script src="../JavaScript/custom.min.js"></script>
    <link href="../Styles/AdminPanelStyles.css" rel="stylesheet" />
    <link href="../font-awesome-4.3.0/css/font-awesome.min.css" rel="stylesheet" />
    <script src="../HighCharts/highcharts.js"></script>
    <script src="../HighCharts/exporting.src.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="oh" class="c-content">
        <div id="demo-form2" class="form-horizontal form-label-right">
            <div class="col-md-6 col-md-offset-3 col-xs-12">
                <hc:chart ID="chart" runat="server"></hc:chart>
            </div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        </div>
        <%-- <telerik:ReportViewer runat="server"></telerik:ReportViewer>--%>
        <%--<rsweb:ReportViewer runat="server" ID="ctl00" Font-Names="Verdana" Font-Size="8pt" ProcessingMode="Remote" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
            <ServerReport ReportPath="test" />
        </rsweb:ReportViewer>--%>
    </div>
</asp:Content>
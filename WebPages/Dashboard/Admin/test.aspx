<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/Admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebPages.Dashboard.Admin.test" %>

<%@ Register Src="~/Controllers/HighChartsControl.ascx" TagPrefix="hc" TagName="chart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link href="../Styles/bootstrap.css" rel="stylesheet" />
    <link href="../Styles/simple-sidebar.css" rel="stylesheet" />
    <script src="../JavaScript/custom.min.js"></script>
    <link href="../Styles/AdminPanelStyles.css" rel="stylesheet" />
    <link href="../font-awesome-4.3.0/css/font-awesome.min.css" rel="stylesheet" />
    <script src="../HighCharts/highcharts.js"></script>
    <script src="../HighCharts/exporting.src.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="c-content">
        <div id="demo-form2" class="form-horizontal form-label-right">
            <div class="col-md-6 col-md-offset-3 col-xs-12">
                <hc:chart runat="server"></hc:chart>
            </div>
        </div>
    </div>
</asp:Content>
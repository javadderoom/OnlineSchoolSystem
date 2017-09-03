<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/Admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="reportsLessonGroupsChart.aspx.cs" Inherits="WebPages.Dashboard.Admin.reportsLessonGroupsChart" %>

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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="c-title">
        <h4>
            <asp:Literal runat="server" Text="<%$ Resources:sasanRes,chart%>" />
        </h4>
    </div>
    <div class="form-group">
        <div class="row">

            <div class="col-xs-12 col-sm-3  text-right dirRight goLeft">
                <span id="iii" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,classnum%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lblClassNum" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>
            <div class="col-xs-12 col-sm-3  text-right dirRight goLeft">
                <span id="yyy" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,teacher%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lblTeacharName" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>
            <div class="col-xs-12 col-sm-3  text-right dirRight goLeft">
                <span id="ooo" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,classcount%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lblStuCount" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>
            <div class="col-xs-12 col-sm-3  text-right dirRight goLeft">
                <span id="ooo" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,lessontitle%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lblLessonTitle" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>
        </div>
    </div>

    <div class="ln_solid"></div>
    <div class="form-group">
        <div class="row">

            <div class="col-xs-12 col-sm-3  text-right dirRight goLeft" style="float: right">
                <span id="ContentPlaceHolder1_Label2" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,mianginkatbi%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lblmianginkatbi" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>
            <div class="col-xs-12 col-sm-3  text-right dirRight goLeft" style="float: right">
                <span id="ContentPlaceHolder1_Label4" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,mianginshafahi%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lblmianginshafahi" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>

        </div>
    </div>
    <div class="ln_solid"></div>
    <div class="form-group">
        <div class="row">


            <div class="col-xs-12 col-sm-3  text-right dirRight goRight" style="float: right">
                <span id="ContentPlaceHolder1_Label3" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,tamrincount%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lbltamrincount" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>

            <div class="col-xs-12 col-sm-3 text-right dirRight goRight" style="float: right">
                <span id="ContentPlaceHolder1_Label1" class="control-label formLabel" style="color: #666666; font-size: 100%; font-weight: bold;">
                    <asp:Literal runat="server" Text="<%$ Resources:sasanRes,percentamrinanswer%>" /></span>
                <span class="fa fa-arrow-circle-down"></span>
                <br />
                <span runat="server" id="lblanswer" class="control-label formLabel" style="color: #0066CC; font-size: 100%; font-weight: bold;"></span>
            </div>
        </div>
    </div>
    <div class="ln_solid"></div>

    <div class="extra" style="height: 100px">
    </div>
</asp:Content>

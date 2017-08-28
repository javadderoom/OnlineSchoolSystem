<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="MScores.aspx.cs" Inherits="WebPages.Dashboard.MScores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link href="Styles/bootstrap.css" rel="stylesheet" />
    <link href="Styles/simple-sidebar.css" rel="stylesheet" />
    <link href="Styles/AdminPanelStyles.css" rel="stylesheet" />

    <%--  <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/simple-sidebar.css" rel="stylesheet" />--%>
    <link href="font-awesome-4.3.0/css/font-awesome.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="c-title">
        <h4>
            <asp:literal runat="server" text="<%$ Resources:Dashboard,karname_mahane%>" />
        </h4>
    </div>
    <div class="extra" style="height: 100px">
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
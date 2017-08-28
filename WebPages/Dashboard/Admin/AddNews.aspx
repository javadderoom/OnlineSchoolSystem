<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/Admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="WebPages.Dashboard.Admin.AddNews" %>

<%--<%@ Page Theme="Default" Language="C#" AutoEventWireup="true" CodeFile="DefaultCS.aspx.cs" Inherits="Telerik.Web.Examples.Editor.Overview.DefaultCS" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>--%>

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
    <%-- <script src="ckeditor/ckeditor.js"></script>
    <script src="ckeditor/build-config.js"></script>--%>
    <!-- Make sure the path to CKEditor is correct. -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="c-title">
        <h4>
            <asp:Literal runat="server" Text="<%$ Resources:Dashboard,AddNews%>" />
        </h4>
    </div>

    <%-- <div style="direction: rtl;">
        <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
        <telerik:RadSkinManager ID="RadSkinManager1" runat="server" ShowChooser="true" />
        <div class="demo-containers">
            <div class="demo-container">
                <telerik:RadEditor RenderMode="Lightweight" runat="server" ID="RadEditor1" SkinID="DefaultSetOfTools"
                    Height="675px">
                    <imagemanager viewpaths="~/Editor/images/UserDir/Marketing,~/Editor/images/UserDir/PublicRelations"
                        uploadpaths="~/Editor/images/UserDir/Marketing,~/Editor/images/UserDir/PublicRelations"
                        deletepaths="~/Editor/images/UserDir/Marketing,~/Editor/images/UserDir/PublicRelations"
                        enableasyncupload="true"></imagemanager>
                </telerik:RadEditor>
            </div>
        </div>
        <telerik:RadAjaxLoadingPanel runat="server" ID="RadAjaxLoadingPanel1">
        </telerik:RadAjaxLoadingPanel>
        <telerik:RadAjaxManager runat="server" ID="RadAjaxManager1">
            <ajaxsettings>
            <telerik:AjaxSetting AjaxControlID="CheckBoxListEditMode">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadEditor1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="CheckBoxListEditMode" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadioButtonToolsFile">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadEditor1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="RadioButtonToolsFile" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CheckBoxListModules">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadEditor1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="CheckBoxListModules" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadioButtonListEnabled">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadEditor1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="RadioButtonListEnabled" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="NewLineModeButtonList">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadEditor1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="NewLineModeButtonList" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="CheckBoxListModules">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadEditor1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="CheckBoxListModules" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </ajaxsettings>
        </telerik:RadAjaxManager>
    </div>--%>
    <div class="extra" style="height: 100px">
    </div>
</asp:Content>
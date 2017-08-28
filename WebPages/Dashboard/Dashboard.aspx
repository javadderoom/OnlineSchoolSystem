<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebPages.Dashboard.Kartabl" %>

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
        <h4>مشخصات شخصی</h4>
    </div>
    <div class="c-content">
        <%--<div id="demo-form2" class="form-horizontal form-label-right">--%>
        <div class="col-md-6 col-md-offset-3 col-xs-12">
            <div id="ContentPlaceHolder1_upWait">

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 text-center">

                            <img id="imgUserPic" class="img-responsive center-margin" runat="server" src="Images/3408.jpg" style="height: 100px; width: 100px;" />
                        </div>
                    </div>
                </div>

                <div class="ln_solid"></div>
                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_StuID" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,ID%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblStuID" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_StudentCode" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,shomare_daneshamozi%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblStudentCode" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_FirstName" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,name%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblFirstName" runat="server" class="control-label formLabel">مجید</span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_LastName" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,family%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblLastName" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_Field" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,reshte_tahsili%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblField" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <%-- <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_Level" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,maghta%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblLevel" runat="server" class="control-label formLabel">کارشناسی پیوسته</span>
                        </div>
                    </div>
                </div>--%>
                <div class="ln_solid"></div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 text-right dirRight">
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_FatherName" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,father_name%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblFatherName" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_BirthYear" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,birthday%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblBirthYear" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_IDNumber" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,codemelli%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblIDNumber" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_FixTel" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,telephon_sabet%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblFixTel" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_Mobile" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,mobile%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblMobile" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_ZipCode" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,postal_code%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblZipCode" runat="server" class="control-label formLabel">۴۴۱۸۷۹۴۳۵۹</span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_Email" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,email%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblEmail" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4 col-sm-push-8 text-right">
                            <span id="ContentPlaceHolder1_lbl_Address" class="control-label formLabel" style="font-size: 100%; font-weight: bold;">
                                <asp:Literal runat="server" Text="<%$ Resources:Dashboard,address%>" /></span>
                        </div>

                        <div class="col-xs-12 col-sm-8 col-sm-pull-4 text-right">
                            <span id="lblAddress" runat="server" class="control-label formLabel"></span>
                        </div>
                    </div>
                </div>
            </div>

            <div class="ln_solid"></div>
            <div class="form-group">
                <div class="col-xs-12 text-right">
                    <a class="btn btn-auto-v btn-auto-h btn-primary goRight" href="http://localhost:4911/Dashboard/EditProfile.aspx">
                        <asp:Literal runat="server" Text="<%$ Resources:Dashboard,edite%>" />
                        <span class="fa fa-edit"></span>
                    </a>
                </div>
            </div>
            <div class="extra" style="height: 100px">
            </div>
        </div>
        <%--</div>--%>
    </div>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/Admin/AdminPanel.Master" AutoEventWireup="true" CodeBehind="Picture.aspx.cs" Inherits="WebPages.Dashboard.Admin.Picture" %>

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
            <asp:Literal runat="server" Text="<%$ Resources:Dashboard,change_picture%>" /></h4>
    </div>
    <div class="c-content">
        <%--<div id="demo-form2" class="form-horizontal form-label-right">--%>
        <div class="col-md-6 col-md-offset-3 col-xs-12">
            <div id="ContentPlaceHolder1_upWait">

                <div class="form-group">
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 text-center">

                            <img id="imgUserPic" class="img-responsive center-margin" runat="server" src="" style="height: 100px; width: 100px;" />
                        </div>
                    </div>
                </div>
                <div class="ln_solid"></div>
                <div class="form-group">
                    <div class="row">


                        <div class="col-xs-12 col-sm-10 col-sm-pull-2 text-right input-group">
                            <label class="btn btn-info">
                                &hellip;<asp:Literal runat="server" Text="<%$ Resources:Dashboard,select_img%>" />
                                <asp:FileUpload ID="FileUpload1" runat="server" accept="image/*" CssClass="displaynone" BackColor="#CCCCCC" />

                            </label>

                        </div>
                    </div>
                </div>

                <div class="ln_solid"></div>
                <div class="form-group">
                    <div class="col-xs-12 text-right">
                        <asp:Button ID="Button1" name="btnSabt" class="btn btn-primary" runat="server"
                            Text="<%$ Resources:Dashboard,sabt%>" OnClick="Button1_Click" />
                    </div>
                </div>
                <div class="extra" style="height: 100px">
                </div>
            </div>
            <%--</div>--%>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="PageDetail.aspx.cs" Inherits="TumblrClone.VIEWS.PageDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    * { box-sizing: border-box; }

    /* force scrollbar */

    html { overflow-y: scroll; }

    body {
        font-family: sans-serif;
        background: #DDD;
    }


    /* NAVBAR */

    #upload { border-style: dotted; }

    .navbar-brand { padding-bottom: .8125rem !important; }

    .image-center {
        display: block;
        margin-left: auto;
        margin-right: auto;
    }

    .image-post {
        margin-top: 2%;
        padding-top: 3%;
    }

    body { background-color: #f3f3f3; }

    h1 { font-size: 21px; }

    h2 { font-size: 18px; }

    h3,
    h4,
    h5,
    h6 { font-size: 16px; }

    .wall-post { border-color: #eae9e9; }

    .wall-post .wall-post-header {
        background-color: #fbfafa;
        border-color: #eae9e9;
    }

    .wall-post .wall-post-header img {
        display: inline-block;

        margin-right: 10px;
    }

    .wall-post .wall-post-header h2 {
        display: inline-block;
        margin: 0;
    }

    .wall-post .wall-post-header h2 small { display: block; }

    .wall-post .wall-post-footer {
        background-color: #fbfafa;
        border-color: #eae9e9;
    }

    /*Modal*/

    #myImg {
        border-radius: 5px;
        cursor: pointer;
        transition: 0.3s;
    }

    #myImg:hover { opacity: 0.7; }

    /* The Modal (background) */

    .modal {
        display: none;
        /* Hidden by default */
        position: fixed;
        /* Stay in place */
        z-index: 1;
        /* Sit on top */
        padding-top: 100px;
        /* Location of the box */
        left: 0;
        top: 0;
        width: 100%;
        /* Full width */
        height: 100%;
        /* Full height */
        overflow: auto;
        /* Enable scroll if needed */
        background-color: rgb(0, 0, 0);
        /* Fallback color */
        background-color: rgba(0, 0, 0, 0.9);
        /* Black w/ opacity */
    }

    /* Modal Content (image) */

    .modal-content {
        margin: auto;
        display: block;
        width: 80%;
        max-width: 700px;
    }

    /* Caption of Modal Image */

    #caption {
        margin: auto;
        display: block;
        width: 80%;
        max-width: 700px;
        text-align: center;
        color: #ccc;
        padding: 10px 0;
        height: 150px;
    }

    /* Add Animation */

    .modal-content,
    #caption {
        -webkit-animation-name: zoom;
        -webkit-animation-duration: 0.6s;
        animation-name: zoom;
        animation-duration: 0.6s;
    }

    @-webkit-keyframes zoom {
        from { -webkit-transform: scale(0) }

        to { -webkit-transform: scale(1) }
    }

    @keyframes zoom {
        from { transform: scale(0) }

        to { transform: scale(1) }
    }

    /* The Close Button */

    .close {
        position: absolute;
        top: 15px;
        right: 35px;
        color: #f1f1f1;
        font-size: 40px;
        font-weight: bold;
        transition: 0.3s;
    }

    .close:hover,
    .close:focus {
        color: #bbb;
        text-decoration: none;
        cursor: pointer;
    }

    /* 100% Image Width on Smaller Screens */

    @media only screen and (max-width: 700px) {
        .modal-content { width: 100%; }
    }

    #myImg { width: 60%; }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="image-post">
            <!-- <img id="myImg" class="image-center" src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/82/orange-tree.jpg"/>-->
            <asp:Image ID="myImg" CssClass="image-center" runat="server"/>
            <div class="image-body" style="margin-left: auto; margin-right: auto;">
                <!-- The Modal -->
                <div id="myModal" class="modal">
                    <span class="close">&times;</span>
                    <img class="modal-content" id="img01">
                    <div id="caption"></div>
                </div>
                <div class="container" style="margin-top: 20px;">
                    <div class="row">
                        <div class="col-md-12" style="margin-bottom: 20px;">
                            <div class="status-post">
                                <asp:TextBox CssClass="form-control" ID="tbComment" TextMode="MultiLine" runat="server"></asp:TextBox>
                                <asp:Button CssClass="btn btn-default pull-right" ID="btnSubmit" runat="server" Text="Comment" OnClick="btnSubmit_Click" />
                            </div>
                        </div>
                    </div>
                    <!--posts-->
                    <div class="row">
                        <div class="col-md-12">
                            <asp:Repeater ID="rptCmt" runat="server">
                                <ItemTemplate>
                                    <div class="panel panel-default wall-post">
                                        <div class="panel-heading wall-post-header">
                                            <h2>
                                                <a href=""><%# Eval("USERNAME") %></a>
<%--                                                <small>Posted 12 hr ago</small>--%>
                                            </h2>
                                        </div>
                                        <div class="panel-body wall-post-body">
                                            <div class="wall-post-content">
                                                <p>
                                                    <%# Eval("CONTENT") %>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        // Get the modal
        var modal = document.getElementById('myModal');

        // Get the image and insert it inside the modal - use its "alt" text as a caption
        var img = document.getElementById('ContentPlaceHolder1_myImg');
        var modalImg = document.getElementById("img01");
        var captionText = document.getElementById("caption");
        img.onclick = function() {
            modal.style.display = "block";
            modalImg.src = this.src;
            captionText.innerHTML = this.alt;
        }

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName("close")[0];

        // When the user clicks on <span> (x), close the modal
        span.onclick = function() {
            modal.style.display = "none";
        }
    </script>
</asp:Content>
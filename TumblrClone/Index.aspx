<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TumblrClone.VIEWS.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        @import url('https://fonts.googleapis.com/css?family=Roboto');
        /* force scrollbar */

        html {
            overflow-y: scroll;
            font-family: 'Roboto', sans-serif;
        }

        body {
            font-family: sans-serif;
            background: #DDD;
        }

        #upload {
            border-style: dotted;
        }

        /* ---- grid ---- */

        .grid {

            margin-top: 2%
        }

        /* clear fix */

        .grid:after {
            content: '';
            display: block;
            clear: both;
        }

        /* ---- .grid-item ---- */

        .grid-sizer,
        .grid-item {
            width: 23%;
            margin: 2px
        }

        .grid-item {
            float: left;

        }

        .grid-item img {
            display: block;
            max-width: 100%;
        }

        .card .card-body {
            padding: 0 !important
        }

        .border figure img {
            -webkit-transform: scale(1);
            transform: scale(1);
            -webkit-transition: .3s ease-in-out;
            transition: .3s ease-in-out;
        }

        .border figure:hover img {
            -webkit-transform: scale(1.3);
            transform: scale(1.3);
        }

        figure {
            margin: 0;
            padding: 0;
            background: #fff;
            overflow: hidden;
        }

        figure:hover+span {
            bottom: -36px;
            opacity: 1;
        }

        /* Modal */

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
            from {
                -webkit-transform: scale(0)
            }
            to {
                -webkit-transform: scale(1)
            }
        }

        @keyframes zoom {
            from {
                transform: scale(0)
            }
            to {
                transform: scale(1)
            }
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
            .modal-content {
                width: 100%;
            }
        }

        a {

            text-decoration: none !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!--CONTENT-->
    <div class="grid">
        <asp:Label ID="lbTest" runat="server" Text="Label"></asp:Label>
        <div class="grid-sizer"></div>
        <asp:Repeater ID="RptPost" runat="server">
            <ItemTemplate>
                 <div class="grid-item card rounded border">
                        <a href="/PageDetail.aspx?id=<%# Eval("ID") %>">
                            <figure>
                                <img class="card-img-top" src="./IMAGES/<%# Eval("IMAGE_URL") %>" alt="Trolltunga, Norway"/>
                            </figure>
                        </a>
                        <div class="card-body">
                            <span style="float: right; font-size: 0.9em"><%# Eval("COUNT_LIKE") %></span>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%# Eval("ID") %>' OnClick="btnLike_Click">
                                <i style="float: right; margin-top: 4px; margin-right: 1px; color:red;" class="fa fa-heart-o" style="font-size:24px"></i>
                            </asp:LinkButton>
                        </div>
                  </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <script type="text/javascript" src="../Assets/js/jquery.lazy.min.js"></script>
    <script type="text/javascript" src="../Assets/js/jquery.lazy.picture.min.js"></script>
    <script type="text/javascript" src="../Assets/js/masonry.pkgd.min.js"></script>
    <script type="text/javascript" src="../Assets/js/imagesloaded.pkgd.min.js"></script>
    <script>
        var $grid = $('.grid').imagesLoaded(function () {
            $grid.masonry({
                itemSelector: '.grid-item',
                percentPosition: true,
                columnWidth: '.grid-sizer'
            });
        });
        $(function () {
            console.log('ok');
            $('.lazy').lazy({
                effect: "fadeIn",
                effectTime: 2000,
                delay: 5000,
                threshold: 0
            });
        });
    </script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="MyGallery.aspx.cs" Inherits="TumblrClone.MyGallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        * {
            box-sizing: border-box;
        }

        /* force scrollbar */

        html {
            overflow-y: scroll;
        }

        body {
            font-family: sans-serif;
            background: #DDD;
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
        .main {
            margin-top: 5%
        }

        .grid-item {
            position: relative;
        }

        .card-img-top {
            opacity: 1;
            display: block;
            width: 100%;
            height: auto;
            transition: .5s ease;
            backface-visibility: hidden;
        }

        .middle {
            transition: .5s ease;
            opacity: 0;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            -ms-transform: translate(-50%, -50%);
            text-align: center;
        }

        .grid-item:hover .card-img-top {
            opacity: 0.3;
        }

        .grid-item:hover .middle {
            opacity: 1;
        }
        
        /* ---- .NAV-BAR ---- */
        #upload{
            border-style: dotted;
        }
        .navbar-brand{
            padding-bottom: .8125rem !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="grid">
         <div class="grid-sizer"></div>
         <asp:Repeater ID="RptGallery" runat="server">
            <ItemTemplate>
            <div class="grid-item card rounded border">
                <img class="card-img-top" src="./IMAGES/<%# Eval("IMAGE_URL") %>" />
                <div class="middle">
                   <asp:Button ID="Button1" CssClass="btn btn-danger" CommandName='<%# Eval("ID") %>' runat="server" Text="Delete" OnClick = "btnDelete_Click" />
                </div>
            </div>
                </ItemTemplate>
             </asp:Repeater>
     </div>
    <script>
        var $grid = $('.grid').imagesLoaded(function () {
            $grid.masonry({
                itemSelector: '.grid-item',
                percentPosition: true,
                columnWidth: '.grid-sizer'
            });
        });
    </script>
</asp:Content>

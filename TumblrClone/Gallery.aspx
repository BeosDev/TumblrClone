<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="TumblrClone.Gallery" %>
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
    <asp:Label ID="lb1" runat="server" Text="Label"></asp:Label>
          <div class="grid">
              <div class="grid-sizer"></div>
    <asp:Repeater ID="rptGallery" runat="server">
        <ItemTemplate>
            
            <div class="grid-item card rounded border">
                <img class="card-img-top" src="./IMAGES/<%# Eval("IMAGE_URL") %>"/>
                <div class="card-body">
                </div>
                <div class="middle">
                        <asp:Button ID="Delete"  CssClass="btn btn-danger" runat="server" Text="Button" OnClick = "btnDelete_Click" CommandName = '<%# Eval("ID") %>' />
                </div>
            </div>
        
            </ItemTemplate>
    </asp:Repeater>
              </div>
    <script type="text/javascript" src="./Assets/js/jquery.lazy.min.js"></script>
    <script type="text/javascript" src="./Assets/js/jquery.lazy.picture.min.js"></script>
    <script type="text/javascript" src="./Assets/js/masonry.pkgd.min.js"></script>
    <script type="text/javascript" src="./Assets/js/imagesloaded.pkgd.min.js"></script>
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

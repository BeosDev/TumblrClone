<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="TumblrClone.Upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron">
              <h2>UPLOAD</h2>
        </div>
        Title :<asp:TextBox ID="txb_title" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        UID :<asp:TextBox ID="txb_uid" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        <br />
        Image url :<asp:FileUpload ID="fu_image" runat="server" CssClass="form-control"/>
        <br />
        Description :<asp:TextBox ID="txb_description" runat="server" Height="84px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="btn_upload" runat="server" OnClick="btn_upload_Click" Text="Upload" CssClass="btn btn-primary   E3DC    "/>
        <br />
    
    </div>
</asp:Content>

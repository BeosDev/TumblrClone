<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="TumblrClone.EditPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron">
            <h2>EDIT POST</h2>
        </div>
        Title :<asp:TextBox ID="txb_title" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        UID :<asp:TextBox ID="txb_uid" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        Image url :<asp:FileUpload ID="fu_image" runat="server" CssClass="form-control"/>
        <br />
        Description :<asp:TextBox ID="txb_description" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="btn_edit" runat="server" Text="Edit" OnClick="btn_edit_Click" />
        <br />
    </div>
</asp:Content>

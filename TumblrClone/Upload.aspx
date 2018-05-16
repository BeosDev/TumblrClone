<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="TumblrClone.Upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>UPLOAD</h2>
        Title :<asp:TextBox ID="txb_title" runat="server"></asp:TextBox>
        <br />
        UID :<asp:TextBox ID="txb_uid" runat="server"></asp:TextBox>
        <br />
        Image url :<asp:FileUpload ID="fu_image" runat="server" />
        <br />
        Description :<asp:TextBox ID="txb_description" runat="server" Height="88px" TextMode="MultiLine" Width="255px"></asp:TextBox>
        <br />
        <asp:Button ID="btn_upload" runat="server" Text="Upload" OnClick="btn_upload_Click" />
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" />
    
    </div>
</asp:Content>

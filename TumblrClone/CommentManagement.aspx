<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="CommentManagement.aspx.cs" Inherits="TumblrClone.CommentManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="UID" HeaderText="User_ID" />
            <asp:BoundField DataField="PID" HeaderText="Person_ID" />
            <asp:BoundField DataField="CONTENT" HeaderText="Content" />
            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="/CommentManagement.aspx?delete={0}" HeaderText="Delete" NavigateUrl="/CommentManagement.aspx?delete={0}" Text="Delete" />
        </Columns>
    </asp:GridView>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="CommentManagement.aspx.cs" Inherits="TumblrClone.CommentManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="UID" HeaderText="User_ID" />
            <asp:BoundField DataField="PID" HeaderText="Person_ID" />
            <asp:BoundField DataField="CONTENT" HeaderText="Content" />
        </Columns>
    </asp:GridView>
</asp:Content>

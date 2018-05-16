<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="PostManagement.aspx.cs" Inherits="TumblrClone.PostManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="TITLE" HeaderText="TITLE" />
            <asp:BoundField DataField="UID" HeaderText="UID" />
            <asp:BoundField DataField="IMAGE_URL" HeaderText="IMAGE_URL" />
            <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" />
            <asp:TemplateField HeaderText="EDIT">
                <ItemTemplate>
                    <asp:Button ID="btn_edit" runat="server" CommandName='<%#Eval("Id") %>' OnClick="Edit.aspx" Text="EDIT" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DELETE">
                <ItemTemplate>
                    <asp:Button ID="btn_delete" runat="server" CommandName='<%#Eval("Id") %>' OnClick="delete_Click" Text="DELETE" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

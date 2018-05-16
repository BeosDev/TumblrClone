<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="PostManagement.aspx.cs" Inherits="TumblrClone.PostManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron">
            <h2>Post Manegement</h2>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-hover table-responsive">
            <Columns>
                <asp:BoundField DataField="TITLE" HeaderText="TITLE" />
                <asp:BoundField DataField="UID" HeaderText="UID" />
                <asp:BoundField DataField="IMAGE_URL" HeaderText="IMAGE_URL" />
                <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" />
                <asp:TemplateField HeaderText="EDIT">
                    <ItemTemplate>
                        <a href="/EditPost.aspx?id=<%# Eval("Id") %>">Edit</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DELETE">
                    <ItemTemplate>
                        <asp:Button ID="btn_delete" runat="server" CommandName='<%#Eval("Id") %>' OnClick="delete_Click" Text="DELETE" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>

</asp:Content>

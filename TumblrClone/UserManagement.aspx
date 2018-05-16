<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="TumblrClone.UserManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron">
            <h1>User Management</h1>
        </div>
        <!-- Button to Open the Modal -->
        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal" onclick="addClick()">
            Add a new user
        </button>

        <!-- The Modal -->
        <div class="modal" id="myModal">
            <div class="modal-dialog">
                <div class="modal-content">

                    <!-- Modal Header -->
                    <div class="modal-header">
                        <h4 class="modal-title" id="modal-title"></h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>

                    <!-- Modal body -->
                    <div class="modal-body">
                        <asp:HiddenField ID="hfID" runat="server" />
                        <div class="form-group">
                            <label>USERNAME:</label>
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>PASSWORD:</label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>FULL NAME:</label>
                            <asp:TextBox ID="txtFullname" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>TYPE OF USER:</label>
                            <asp:DropDownList ID="ddlTypeOfUser" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Admin" Value="0"></asp:ListItem>
                                <asp:ListItem Text="User" Value="1"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                    <!-- Modal footer -->
                    <div class="modal-footer">
                        <asp:Button ID="btn" runat="server" CssClass="btn btn-primary" OnClick="btn_Click"/>
                        <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>

                </div>
            </div>
        </div>
        <table class="table table-hover table-responsive">
            <tr>
                <th>ID</th>
                <th>USERNAME</th>
                <th>FULL NAME</th>
                <th>TYPE OF USERS</th>
                <th>EDIT</th>
                <th>DELETE</th>
            </tr>
            <asp:Repeater ID="rUsers" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID") %></td>
                        <td><%#Eval("USERNAME") %></td>
                        <td><%#Eval("HO_TEN") %></td>
                        <td><%#Eval("LOAI_TK") %></td>
                        <td><a class="btn btn-link" data-toggle="modal" data-target="#myModal" onclick="editClick('<%#Eval("ID") %>','<%#Eval("USERNAME") %>','<%#Eval("PASSWORD") %>','<%#Eval("HO_TEN") %>')">EDIT</a></td>
                        <td><a href="UserManagement.aspx?id=<%#Eval("ID") %>" class="btn btn-link">DELETE</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <script>
            function editClick(id,username,password,hoten) {
                $("#modal-title").text("Edit user:" + id);
                $("#ContentPlaceHolder1_hfID").val(id);
                $("#ContentPlaceHolder1_btn").val("Edit");
                $("#ContentPlaceHolder1_txtUsername").val(username);
                $("#ContentPlaceHolder1_txtPassword").val(password);
                $("#ContentPlaceHolder1_txtFullname").val(hoten);
            }
            function addClick() {
                $("#ID").val("");
                $("#modal-title").text("Add a new user");
                $("#ContentPlaceHolder1_hfID").val("");
                $("#ContentPlaceHolder1_btn").val("Add");
            }
        </script>

    </div>
</asp:Content>

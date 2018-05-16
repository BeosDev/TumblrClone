<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TumblrClone.VIEWS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <link rel="stylesheet" href="../Assets/css/bootstrap.min.css"/>

    <title></title>
</head>
<body>
    <div class="container jumbotron" style="width: 50%;margin-top: 10%">
        <form id="loginForm" runat="server">
            <div class="form-group">
                <label for="txtUsername">Username: </label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password" required="true"></asp:TextBox>
            </div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
        </form>
        <label>Do not have a account? <a href="Register.aspx">Register now!</a></label>
    </div>
</body>
</html>

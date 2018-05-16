<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TumblrClone.Register" %>

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
         <h1 style="color:#007bff;text-align:center;">Register</h1>
        <form id="RegisterForm" runat="server">
            <div class="form-group">
                <label for="txtFullName">FullName: </label>
                <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" placeholder="Full Name" required="true"></asp:TextBox>
            </div>
           
            <div class="form-group">
                <label for="txtUsername">Username: </label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtRe_Password">Re_Password</label>
                <asp:TextBox ID="txtRe_Password" runat="server" CssClass="form-control" placeholder="Re_Password" TextMode="Password" required="true"></asp:TextBox>
            </div>
            <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="btnRegister_Click"  />
           
        </form>
    </div>

 
</body>
</html>

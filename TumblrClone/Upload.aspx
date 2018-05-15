<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="TumblrClone.VIEWS.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Title :<asp:TextBox ID="txb_title" runat="server"></asp:TextBox>
        <br />
        UID :<asp:TextBox ID="txb_uid" runat="server"></asp:TextBox>
        <br />
        Image url :<asp:FileUpload ID="fu_image" runat="server" />
        <br />
        Description :<asp:TextBox ID="txb_description" runat="server" Height="88px" TextMode="MultiLine" Width="255px"></asp:TextBox>
        <br />
        <asp:Button ID="btn_upload" runat="server" Text="Upload" />
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" />
    
    </div>
    </form>
</body>
</html>

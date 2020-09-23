<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="quanli.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1 {
            text-align:center;
            border: solid;
            width: 200px;
            height: 300px;
            position: absolute;
            left: 40%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Đăng nhập</h1></div>
       <div class="form-group">
		  <asp:Label ID="Label5" runat="server" Text="Username:"></asp:Label>        
          <asp:TextBox ID="txtUser"  class="form-control" runat="server"></asp:TextBox>
		</div>
        <br />
         <div class="form-group">
		  <asp:Label ID="Label1" runat="server" Text="Mật khẩu:"></asp:Label>        
          <asp:TextBox ID="txtPass" TextMode="Password"  class="form-control" runat="server"></asp:TextBox>
		</div>
        <br />
        <div class="form-group">
           <asp:Button ID="txtLogin" runat="server" Text="Đăng nhập" class="btn btn-primary" Width="75px" OnClick="txtLogin_Click" />
        </div>
    </form>
</body>
</html>

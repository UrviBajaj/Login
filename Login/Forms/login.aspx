<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 354px;
            width: 465px;
        }
        .auto-style1 {
            text-align: center;
        }
        #Text1 {
            height: 25px;
            width: 177px;
        }
        #Text2 {
            height: 25px;
            width: 177px;
        }
    </style>
</head>
<body style="width: 476px; height: 361px; background-color: #CCFFCC">
    <form id="form1" runat="server">
        <p class="auto-style1">
            Login</p>
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
            </p>
        <p><asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="BtnLogin_Click" Text="Login" />
        </p>


    </form>
</body>
</html>

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
        Username:
        <input id="txtUsername" type="text" /><p>
            &nbsp;</p>
        Password:
        <input id="txtPassword" type="text" /><p>
            &nbsp;</p>
        <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>

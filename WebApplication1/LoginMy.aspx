<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginMy.aspx.cs" Inherits="WebApplication1.LoginMy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login runat="server" OnAuthenticate="Unnamed1_Authenticate" ID="Login1">

        </asp:Login>
    </div>
    </form>
</body>
</html>

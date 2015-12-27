<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:TextBox runat="server" ID="T1"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="T1_CalendarExtender" runat="server" BehaviorID="T1_CalendarExtender" TargetControlID="T1"></ajaxToolkit:CalendarExtender>
        <input id="ds" runat="server" />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <ajaxToolkit:ColorPickerExtender ID="TextBox2_ColorPickerExtender" runat="server" BehaviorID="TextBox2_ColorPickerExtender" TargetControlID="TextBox2" SampleControlID="Textbox2" />
        <br />
        <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" OnClick="Button3_Click" Text="Button" />
        <asp:PlaceHolder runat="server" ID="PlaceHolder1"></asp:PlaceHolder>
    </form>
</body>
</html>

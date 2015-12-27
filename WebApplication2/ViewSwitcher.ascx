<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewSwitcher.ascx.cs" Inherits="WebApplication2.ViewSwitcher" %>
<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="ColorStr">
</asp:DropDownList>
<asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="TypesDicti" TypeName="WebApplication2.WebForm1"></asp:ObjectDataSource>
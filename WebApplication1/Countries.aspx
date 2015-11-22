<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Countries.aspx.cs" Inherits="WebApplication1.Countries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="CountryName" HeaderText="CountryName" SortExpression="CountryName" />
                        <asp:BoundField DataField="Abbr" HeaderText="Abbr" SortExpression="Abbr" />
                        <asp:BoundField DataField="PhoneNoFormat" HeaderText="PhoneNoFormat" SortExpression="PhoneNoFormat" />
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerManagment %>" DeleteCommand="DELETE FROM [Countries] WHERE [ID] = ?" InsertCommand="INSERT INTO [Countries] ([CountryName], [Abbr], [PhoneNoFormat], [ID]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:CustomerManagment.ProviderName %>" SelectCommand="SELECT * FROM [Countries] ORDER BY [CountryName]" UpdateCommand="UPDATE [Countries] SET [CountryName] = ?, [Abbr] = ?, [PhoneNoFormat] = ? WHERE [ID] = ?">
                    <DeleteParameters>
                        <asp:Parameter Name="ID" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="CountryName" Type="String" />
                        <asp:Parameter Name="Abbr" Type="String" />
                        <asp:Parameter Name="PhoneNoFormat" Type="String" />
                        <asp:Parameter Name="ID" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="CountryName" Type="String" />
                        <asp:Parameter Name="Abbr" Type="String" />
                        <asp:Parameter Name="PhoneNoFormat" Type="String" />
                        <asp:Parameter Name="ID" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <br />
                <asp:Timer ID="Timer1" runat="server" Interval="5000">
                </asp:Timer>
            </ContentTemplate>


            




        </asp:UpdatePanel>
    </form>
</body>
</html>

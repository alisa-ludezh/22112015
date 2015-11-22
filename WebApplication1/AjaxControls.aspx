<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxControls.aspx.cs" Inherits="WebApplication1.AjaxControls" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
    </title>
    <!--<link href="Styles/StyleSheet1.css" rel="stylesheet" /> -->
</head>
<body>
    <link href="Styles/StyleSheet1.css" rel="stylesheet" />
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
    
    </div>
        <ajaxToolkit:Accordion ID="Accordion1" runat="server" HeaderCssClass="panelHeader" HeaderSelectedCssClass="selectedPanelHeader">
            <Panes>
                <ajaxToolkit:AccordionPane ID="F" runat="server" ContentCssClass="" HeaderCssClass="">
                    <Header>Panel1</Header>
                    <Content>Content</Content>
                </ajaxToolkit:AccordionPane>
                <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server" ContentCssClass="" HeaderCssClass="">
                    <Header>Panel2</Header>
                    <Content>Content</Content>
                </ajaxToolkit:AccordionPane>
                <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server" ContentCssClass="" HeaderCssClass="">
                    <Header>Panel3</Header>
                    <Content>Content</Content>
                </ajaxToolkit:AccordionPane>
            </Panes>
        </ajaxToolkit:Accordion>
    </form>
</body>
</html>

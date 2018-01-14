<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addition.aspx.cs" Inherits="SampleApp.Addition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <link href="css/main.css" rel="stylesheet" type="text/css" />
<body>
    <form id="form1" runat="server">
    <center><div id="divContainer">
    
        <asp:Label ID="Label4" runat="server" CssClass="headingText" Text="Addition"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Value 1 :"></asp:Label>
&nbsp;
        <asp:TextBox ID="addValue1" CssClass="txtBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Value 2 :"></asp:Label>
&nbsp;
        <asp:TextBox ID="addValue2" CssClass="txtBox"  runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add"  />
&nbsp;
        <div class="divResult"><asp:Label ID="sumValue" runat="server">Result</asp:Label></div>

&nbsp;
        <asp:LinkButton ID="linkSub" CssClass="linkButton" runat="server" OnClick="LinkButton1_Click">Goto Subtract</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="linkMultiply" CssClass="linkButton" runat="server" OnClick="linkMultiply_Click">Goto Multiply</asp:LinkButton>
    
    </div></center>
    </form>
</body>
</html>

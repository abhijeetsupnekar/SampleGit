<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloServiceWebClientForm.aspx.cs" Inherits="HelloWebClient.HelloServiceWebClientForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Width="188px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="color: #0066FF" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Get Message" />
    
    </div>
    </form>
</body>
</html>

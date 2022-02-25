<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Controles_De_Servidores.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            this is My Default Page...
        </div>
        <br />
        <div>
            <asp:HyperLink ID="hlMyPage" runat="server" NavigateUrl="MyPage.aspx" Text="MyPage"></asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="btnMyPage" runat="server" Text="Ir a" OnClick="btnMyPage_Click" />
        </div>
        <br/>
        <br />
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Enviar" OnClick="btnSubmit_Click"  />
        </div>
        <br/>
        <br/>
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>

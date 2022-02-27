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
        <asp:Label ID="lblNum1" runat="server" Text="Num1"></asp:Label>:<asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            </div>
        <div>
            <asp:Label ID="lblNum2" runat="server" Text="Num2"></asp:Label>:<asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Button1_Click" />
            <br/>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="lkbtnAdd" runat="server" OnClick="lkbtnAdd_Click">Add</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="ImgbtnAdd" runat="server" BackColor="Yellow" BorderColor="Blue" BorderStyle="Solid" Height="59px" ImageUrl="~/img/descarga.bmp" OnClick="ImgbtnAdd_Click" Width="53px" />
            <br />
            <br />
            <asp:DropDownList ID="ddlQualification" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlQualification_SelectedIndexChanged">
                <asp:ListItem Value="10">Select</asp:ListItem>
                <asp:ListItem Value="1">B.Tech</asp:ListItem>
                <asp:ListItem Value="20">M.Tech</asp:ListItem>
                <asp:ListItem Value="30">Ph.D</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="10">C</asp:ListItem>
                <asp:ListItem Value="20">C++</asp:ListItem>
                <asp:ListItem Value="30">C#</asp:ListItem>
                <asp:ListItem Value="40">Java</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="lblDDLResult" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                <asp:ListItem Value="10">Sumar</asp:ListItem>
                <asp:ListItem Value="20">Restar</asp:ListItem>
                <asp:ListItem Value="30">Dividir</asp:ListItem>
                <asp:ListItem Value="40">Multiplicar</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </form>
</body>
</html>

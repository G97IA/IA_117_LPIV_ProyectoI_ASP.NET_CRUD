<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppG6_19.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <style type="text/css">
        .auto-style1 {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table border="1" style="width: 40%;" align="Center" rules="none">
                <tr>           
                    <td  colspan="2" align="Center" >Inicio de Sesión</td>
                    
                </tr>
                <tr>
                    <td  colspan="2" align="Center" >Ingrese su Nombre de Usuario Y Contraseña</td>
                </tr>
                <tr>
                    <td class="auto-style3">Nombre de Usuario: </td>
                    
                    <td class="auto-style2">
                        <asp:TextBox ID="UserName" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Contraseña: </td>
                    
                    <td class="auto-style5">
                        <asp:TextBox ID="Password" runat="server" textmode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Ingresar" />
                    
                        <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label>
                     </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>

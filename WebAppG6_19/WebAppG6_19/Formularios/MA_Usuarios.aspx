<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MA_Usuarios.aspx.cs" Inherits="WebAppG6_19.Formularios.MA_Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="Gv_Usuarios" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" ShowFooter="True" OnRowCommand="Gv_Usuario_RowCommand" style="margin-right: 0px" Width="607px" OnRowCancelingEdit="Gv_Usuarios_RowCancelingEdit" OnRowEditing="Gv_Usuarios_RowEditing" OnRowUpdating="Gv_Usuarios_RowUpdating" OnRowDeleting="Gv_Usuarios_RowDeleting">
    <AlternatingRowStyle BackColor="#DCDCDC" />
    <Columns>
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        <asp:TemplateField HeaderText="Usuario" SortExpression="USUARIO">
            <EditItemTemplate>
                <asp:TextBox ID="TxtUsuario" runat="server" Text='<%# Bind("USUARIO") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtUsuario" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="LblUsuario" runat="server" Text='<%# Bind("USUARIO") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nombres" SortExpression="NOMBRES">
            <EditItemTemplate>
                <asp:TextBox ID="TxtNombres" runat="server" Text='<%# Bind("NOMBRES") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtNombre" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("NOMBRES") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Apellidos" SortExpression="APELLIDOS">
            <EditItemTemplate>
                <asp:TextBox ID="TxtApellidos" runat="server" Text='<%# Bind("APELLIDOS") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtApellido"  runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("APELLIDOS") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Clave" SortExpression="CLAVE">
            <EditItemTemplate>
                <asp:TextBox ID="TxtClave" runat="server" Text='<%# Bind("CLAVE") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtClave" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("CLAVE") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Rol" SortExpression="ROL">
            <EditItemTemplate>
                <asp:DropDownList ID="DdlRoles" runat="server">
                    <asp:ListItem Value="1">ADMINISTRADOR1</asp:ListItem>
                    <asp:ListItem Value="2">ADMINISTRADOR2</asp:ListItem>
                    <asp:ListItem Value="3">ADMINISTRADOR3</asp:ListItem>
                    <asp:ListItem Value="4">ADMINISTRADOR5</asp:ListItem>
                    <asp:ListItem Value="5">ADMINISTRADOR6</asp:ListItem>
                    <asp:ListItem Value="6">USUARIO1</asp:ListItem>
                    <asp:ListItem Value="7">USUARIO2</asp:ListItem>
                    <asp:ListItem Value="8">USUARIO3</asp:ListItem>
                    <asp:ListItem Value="9">USUARIO4</asp:ListItem>
                    <asp:ListItem Value="10">USUARIO5</asp:ListItem>
                </asp:DropDownList>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:DropDownList ID="FDdlRoles" runat="server">
                    <asp:ListItem Value="1">ADMINISTRADOR1</asp:ListItem>
                    <asp:ListItem Value="2">ADMINISTRADOR2</asp:ListItem>
                    <asp:ListItem Value="3">ADMINISTRADOR3</asp:ListItem>
                    <asp:ListItem Value="4">ADMINISTRADOR5</asp:ListItem>
                    <asp:ListItem Value="5">ADMINISTRADOR6</asp:ListItem>
                    <asp:ListItem Value="6">USUARIO1</asp:ListItem>
                    <asp:ListItem Value="7">USUARIO2</asp:ListItem>
                    <asp:ListItem Value="8">USUARIO3</asp:ListItem>
                    <asp:ListItem Value="9">USUARIO4</asp:ListItem>
                    <asp:ListItem Value="10">USUARIO5</asp:ListItem>
                </asp:DropDownList>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label5" runat="server" Text='<%# Bind("ROL") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Estado" SortExpression="ESTADO">
            <EditItemTemplate>
                <asp:DropDownList ID="DdlEstado" runat="server">
                    <asp:ListItem Value="A">Activo</asp:ListItem>
                    <asp:ListItem Value="I">Inactivo</asp:ListItem>
                </asp:DropDownList>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:DropDownList ID="FDdlEstado" runat="server">
                    <asp:ListItem Value="A">Activo</asp:ListItem>
                    <asp:ListItem Value="I">Inactivo</asp:ListItem>
                </asp:DropDownList>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" Text='<%# Bind("ESTADO") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Correo" SortExpression="CORREO">
            <EditItemTemplate>
                <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
            </EditItemTemplate>
             <FooterTemplate>
                <asp:TextBox ID="FTxtCorreo" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Fecha_Creado" SortExpression="FECHA_CREADO">
            <EditItemTemplate>
                <asp:TextBox ID="TxtFecha" runat="server"></asp:TextBox>
            </EditItemTemplate>
             <FooterTemplate>
                <asp:TextBox ID="FTxtFecha" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
          <FooterTemplate>
              <asp:Button runat="server" CommandName="Agregar" Text="Agregar Usuario" />
          </FooterTemplate>
         </asp:TemplateField>
        <asp:TemplateField HeaderText="Creado_Por" SortExpression="CREADO_POR">
            <EditItemTemplate>
                <asp:TextBox ID="TxtCreado" runat="server"></asp:TextBox>
            </EditItemTemplate>
             <FooterTemplate>
                <asp:TextBox ID="FTxtCreado" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
     
    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#0000A9" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#000065" />
</asp:GridView>
    <div>
      <asp:Label ID="labelexito" runat="server" Text="" ForeColor="Green"></asp:Label>
      <asp:Label ID="labelerror" runat="server" Text="" ForeColor="Red"></asp:Label>
     </div>
</asp:Content>

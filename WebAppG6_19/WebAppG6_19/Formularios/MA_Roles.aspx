<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MA_Roles.aspx.cs" Inherits="WebAppG6_19.Formularios.MA_Roles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="Gv_Role" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" ShowFooter="True" OnSelectedIndexChanged="Gv_Role_SelectedIndexChanged" AlternatingRowStyle-HorizontalAlign="NotSet" OnRowCommand="Gv_Role_RowCommand" OnRowEditing="Gv_Role_RowEditing" OnRowCancelingEdit="Gv_Role_RowCancelingEdit" OnRowUpdating="Gv_Role_RowUpdating" OnRowDeleting="Gv_Role_RowDeleting">
    <AlternatingRowStyle BackColor="#DCDCDC" />
    <Columns>
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        <asp:TemplateField HeaderText="Rol" SortExpression="ROL">
            <EditItemTemplate>
                <asp:TextBox ID="TxtRol" runat="server" Text='<%# Bind("ROL") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtRol" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="LblRol" runat="server" Text='<%# Bind("ROL") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Descripcion" SortExpression="DESCRIPCION">
            <EditItemTemplate>
                <asp:TextBox ID="TxtDescripcion" runat="server" Text='<%# Bind("DESCRIPCION") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtDescripcion" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="LabelDescripcion" runat="server" Text='<%# Bind("DESCRIPCION") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Modulo" SortExpression="MODULO">
            <EditItemTemplate>
                <asp:TextBox ID="TxtModulo" runat="server" Text='<%# Bind("MODULO") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtModulo"  runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="LabelModulo" runat="server" Text='<%# Bind("MODULO") %>'></asp:Label>
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
                <asp:DropDownList ID="FDdlRoles" runat="server">
                    <asp:ListItem Value="A">Activo</asp:ListItem>
                    <asp:ListItem Value="I">Inactivo</asp:ListItem>
                </asp:DropDownList>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="LabelEstado" runat="server" Text='<%# Bind("ESTADO") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Creacion" SortExpression="CREACION">
            <EditItemTemplate>
                <asp:TextBox ID="TxtCreacion" runat="server" Text='<%# Bind("CREACION") %>'></asp:TextBox>
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="FTxtCreacion" runat="server"></asp:TextBox>
            </FooterTemplate>
            <ItemTemplate>
                <asp:Label ID="LabelCreacion" runat="server" Text='<%# Bind("CREACION") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
          <FooterTemplate>
              <asp:Button runat="server" CommandName="Agregar" Text="Agregar Rol" />
          </FooterTemplate>
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

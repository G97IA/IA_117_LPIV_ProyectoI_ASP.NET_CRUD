<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MA_Formularios.aspx.cs" Inherits="WebAppG6_19.Formularios.MA_Formularios1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="Gv_Formularios" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateColumns="False" ShowFooter="True" style="margin-top: 0px" OnRowCommand="Gv_Formularios_RowCommand" OnRowCancelingEdit="Gv_Formularios_RowCancelingEdit" OnRowEditing="Gv_Formularios_RowEditing" OnRowUpdating="Gv_Formularios_RowUpdating" OnRowDeleting="Gv_Formularios_RowDeleting">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            <asp:TemplateField HeaderText="Formulario" SortExpression="FORMULARIO">
                <EditItemTemplate>
                    <asp:TextBox ID="TxtFormulario" runat="server" Text='<%# Bind("FORMULARIO") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FTxtFormulario" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="LblFormulario" runat="server" Text='<%# Bind("FORMULARIO") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre Tecnico" SortExpression="TECNICO">
                <EditItemTemplate>
                    <asp:TextBox ID="TxtTecnico" runat="server" Text='<%# Bind("TECNICO") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FTxtTecnico" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="LblTecnico" runat="server" Text='<%# Bind("TECNICO") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre Vista" SortExpression="VISTA">
                <EditItemTemplate>
                    <asp:TextBox ID="TxtVista" runat="server" Text='<%# Bind("VISTA") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FTxtVista" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="LblVista" runat="server" Text='<%# Bind("VISTA") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Menu" SortExpression="MENU">
                <EditItemTemplate>
                    <asp:TextBox ID="TxtMenu" runat="server" Text='<%# Bind("MENU") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FTxtMenu" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="LblMenu" runat="server" Text='<%# Bind("MENU") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="URL" SortExpression="URL">
                <EditItemTemplate>
                    <asp:TextBox ID="TxtUrl" runat="server" Text='<%# Bind("URL") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FTxtUrl" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="LblUrl" runat="server" Text='<%# Bind("URL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Orden" SortExpression="ORDEN">
                <EditItemTemplate>
                    <asp:TextBox ID="TxtOrden" runat="server" Text='<%# Bind("ORDEN") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="FTxtOrden" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="LblOrden" runat="server" Text='<%# Bind("ORDEN") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <FooterTemplate>
                    <asp:Button runat="server" CommandName="Agregar" Text="Agregar Formulario" />
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

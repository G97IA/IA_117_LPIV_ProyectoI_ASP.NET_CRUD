using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppG6_19.Formularios
{
    public partial class MA_Roles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRoles();
            }

        }

        private void CargarRoles()
        {
            try
            {
                Clases.BO_Roles ObjRoles = new Clases.BO_Roles();
                var Source = ObjRoles.GetRoles();
                Gv_Role.DataSource = Source;
                Gv_Role.DataBind();
            }
            catch (Exception Ex)
            {

            }
        }

        protected void Gv_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Gv_Role_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Agregar"))
            {
                try
                {
                    Clases.BO_Roles ObjRoles = new Clases.BO_Roles();
                    ObjRoles.ID_ROL1 = (Gv_Role.FooterRow.FindControl("FTxtRol") as TextBox).Text.Trim();
                    ObjRoles.DESCRIPCION1 = (Gv_Role.FooterRow.FindControl("FTxtDescripcion") as TextBox).Text.Trim();
                    ObjRoles.MODULO1 = (Gv_Role.FooterRow.FindControl("FTxtModulo") as TextBox).Text.Trim();
                    ObjRoles.ESTADO1 = (Gv_Role.FooterRow.FindControl("FDdlRoles") as DropDownList).SelectedValue;
                    ObjRoles.CREACION1 =Convert.ToDateTime((Gv_Role.FooterRow.FindControl("FTxtCreacion") as TextBox).Text.Trim());

                    labelexito.Text = ObjRoles.InsertRol();
                    Gv_Role.EditIndex = -1;
                    CargarRoles();
                }
                catch (Exception Ex)
                {
                    labelerror.Text = Ex.Message;
                }
            }
        }

        protected void Gv_Role_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Gv_Role.EditIndex = e.NewEditIndex;
            CargarRoles();
        }

        protected void Gv_Role_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Gv_Role.EditIndex = -1;
            CargarRoles();
        }

        protected void Gv_Role_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Clases.BO_Roles ObjRoles = new Clases.BO_Roles();
                ObjRoles.ID_ROL1=(Gv_Role.Rows[e.RowIndex].FindControl("TxtRol") as TextBox).Text.Trim();
                ObjRoles.DESCRIPCION1=(Gv_Role.Rows[e.RowIndex].FindControl("TxtDescripcion") as TextBox).Text.Trim();
                ObjRoles.MODULO1=(Gv_Role.Rows[e.RowIndex].FindControl("TxtModulo") as TextBox).Text.Trim();
                ObjRoles.ESTADO1=(Gv_Role.Rows[e.RowIndex].FindControl("DdlEstado") as DropDownList).SelectedValue;
                ObjRoles.CREACION1=Convert.ToDateTime((Gv_Role.Rows[e.RowIndex].FindControl("TxtCreacion") as TextBox).Text.Trim());
                labelexito.Text = ObjRoles.UpdateRol();
                Gv_Role.EditIndex = -1;
                CargarRoles();
            }
            catch (Exception Ex)
            {
                labelerror.Text = Ex.Message;
            }
        }

        protected void Gv_Role_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Clases.BO_Roles ObjRoles = new Clases.BO_Roles();
                ObjRoles.ID_ROL1=(Gv_Role.Rows[e.RowIndex].FindControl("LblRol") as Label).Text.Trim();

                labelexito.Text = ObjRoles.DeleteRol();
                Gv_Role.EditIndex = -1;
                CargarRoles();
            }
            catch (Exception Ex)
            {
                labelerror.Text = Ex.Message;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppG6_19.Formularios
{
    public partial class MA_Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if(!IsPostBack)
            {
                CargarUsuarios();
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                Clases.BO_Usuario ObjUsuario = new Clases.BO_Usuario();
                var Source = ObjUsuario.GetUsuarios();
                Gv_Usuarios.DataSource = Source;
                Gv_Usuarios.DataBind();
            }
            catch (Exception Ex)
            {

            }
        }

        protected void Gv_Usuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("Agregar"))
            {
                try
                {
                    Clases.BO_Usuario ObjUsuario = new Clases.BO_Usuario();
                    ObjUsuario.USUARIO1 = (Gv_Usuarios.FooterRow.FindControl("FTxtUsuario") as TextBox).Text.Trim();
                    ObjUsuario.NOMBRES1 = (Gv_Usuarios.FooterRow.FindControl("FTxtNombre") as TextBox).Text.Trim();
                    ObjUsuario.APELLIDOS1 = (Gv_Usuarios.FooterRow.FindControl("FTxtApellido") as TextBox).Text.Trim();
                    ObjUsuario.CLAVE1 = (Gv_Usuarios.FooterRow.FindControl("FTxtClave") as TextBox).Text.Trim();
                    ObjUsuario.ROL1 = Convert.ToInt32((Gv_Usuarios.FooterRow.FindControl("FDdlRoles") as DropDownList).SelectedValue);
                    ObjUsuario.ESTADO1 = (Gv_Usuarios.FooterRow.FindControl("FDdlEstado") as DropDownList).SelectedValue;
                    ObjUsuario.CORREO1 = (Gv_Usuarios.FooterRow.FindControl("FTxtCorreo") as TextBox).Text.Trim();
                    ObjUsuario.FECHA1 = Convert.ToDateTime ((Gv_Usuarios.FooterRow.FindControl("FTxtFecha") as TextBox).Text.Trim());
                    ObjUsuario.CREADO1 = (Gv_Usuarios.FooterRow.FindControl("FTxtCreado") as TextBox).Text.Trim();

                    labelexito.Text = ObjUsuario.InsertUsuario();
                    Gv_Usuarios.EditIndex = -1;
                    CargarUsuarios();
                }
                catch (Exception Ex)
                {
                    labelerror.Text = Ex.Message;
                }
            }
        }

        protected void Gv_Usuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Gv_Usuarios.EditIndex = e.NewEditIndex;
            CargarUsuarios();
        }

        protected void Gv_Usuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Gv_Usuarios.EditIndex = -1;
            CargarUsuarios();
        }

        protected void Gv_Usuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Clases.BO_Usuario ObjUsuario = new Clases.BO_Usuario();
                ObjUsuario.USUARIO1 = (Gv_Usuarios.Rows[e.RowIndex].FindControl("TxtUsuario") as TextBox).Text.Trim();
                ObjUsuario.NOMBRES1 = (Gv_Usuarios.Rows[e.RowIndex].FindControl("TxtNombres") as TextBox).Text.Trim();
                ObjUsuario.APELLIDOS1 = (Gv_Usuarios.Rows[e.RowIndex].FindControl("TxtApellidos") as TextBox).Text.Trim();
                ObjUsuario.CLAVE1 = (Gv_Usuarios.Rows[e.RowIndex].FindControl("TxtClave") as TextBox).Text.Trim();
                ObjUsuario.ROL1 = int.Parse((Gv_Usuarios.Rows[e.RowIndex].FindControl("DdlRoles") as DropDownList).SelectedValue);
                ObjUsuario.ESTADO1 = (Gv_Usuarios.Rows[e.RowIndex].FindControl("DdlEstado") as DropDownList).SelectedValue;
                ObjUsuario.CORREO1 = (Gv_Usuarios.Rows[e.RowIndex].FindControl("TxtCorreo") as TextBox).Text.Trim();
                ObjUsuario.FECHA1 = Convert.ToDateTime ((Gv_Usuarios.Rows[e.RowIndex].FindControl("FTxtFecha") as TextBox).Text.Trim());
                labelexito.Text = ObjUsuario.UpdateUsuario();
                Gv_Usuarios.EditIndex = -1;
                CargarUsuarios();
            }
            catch (Exception EX)
            {
                labelerror.Text = EX.Message;
            }
        }

        protected void Gv_Usuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Clases.BO_Usuario ObjUsuario = new Clases.BO_Usuario();
                ObjUsuario.USUARIO1 = (Gv_Usuarios.Rows[e.RowIndex].FindControl("LblUsuario") as Label).Text.Trim();
               
                labelexito.Text = ObjUsuario.DeleteUsuario();
                Gv_Usuarios.EditIndex = -1;
                CargarUsuarios();

            }
            catch (Exception EX)
            {
                labelerror.Text = EX.Message;
            }
        }
    }
}
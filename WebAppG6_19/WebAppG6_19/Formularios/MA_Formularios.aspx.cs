using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppG6_19.Formularios
{
    public partial class MA_Formularios1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarFormuarios();

            }
        }
        private void CargarFormuarios()
        {
            try
            {
                Clases.BO_Formulario ObjFormulario = new Clases.BO_Formulario();
                var Source = ObjFormulario.GetFormulario();
                Gv_Formularios.DataSource = Source;
                Gv_Formularios.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void Gv_Formularios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Agregar"))
                {
                    Clases.BO_Formulario ObjFormulario = new Clases.BO_Formulario();
                    ObjFormulario.FORMULARIO1 = Convert.ToInt32((Gv_Formularios.FooterRow.FindControl("FTxtFormulario") as TextBox).Text.Trim());
                    ObjFormulario.TECNICO1 = (Gv_Formularios.FooterRow.FindControl("FTxtTecnico") as TextBox).Text.Trim();
                    ObjFormulario.VISTA1 = (Gv_Formularios.FooterRow.FindControl("FTxtVista") as TextBox).Text.Trim();
                    ObjFormulario.MENU1 = Convert.ToInt32((Gv_Formularios.FooterRow.FindControl("FTxtMenu") as TextBox).Text.Trim());
                    ObjFormulario.URL1 = (Gv_Formularios.FooterRow.FindControl("FTxtUrl") as TextBox).Text.Trim();
                    ObjFormulario.ORDEN1 = Convert.ToInt32((Gv_Formularios.FooterRow.FindControl("FTxtOrden") as TextBox).Text.Trim());

                    labelexito.Text = ObjFormulario.InsertFormulario();
                    Gv_Formularios.EditIndex = -1;
                    CargarFormuarios();
                    labelerror.Text = "";
                    
                }
            }
            catch (Exception Ex)
            {
                labelerror.Text = Ex.Message;
                labelexito.Text = "";

            }


        }

        protected void Gv_Formularios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Gv_Formularios.EditIndex = e.NewEditIndex;
            CargarFormuarios();

        }

        protected void Gv_Formularios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Gv_Formularios.EditIndex = -1;
            CargarFormuarios();
        }

        protected void Gv_Formularios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                Clases.BO_Formulario ObjFormulario = new Clases.BO_Formulario();
                ObjFormulario.FORMULARIO1 = int.Parse((Gv_Formularios.Rows[e.RowIndex].FindControl("TxtFormulario") as TextBox).Text.Trim());
                ObjFormulario.TECNICO1 = (Gv_Formularios.Rows[e.RowIndex].FindControl("TxtTecnico") as TextBox).Text.Trim();
                ObjFormulario.VISTA1 = (Gv_Formularios.Rows[e.RowIndex].FindControl("TxtVista") as TextBox).Text.Trim();
                ObjFormulario.MENU1 = int.Parse((Gv_Formularios.Rows[e.RowIndex].FindControl("TxtMenu") as TextBox).Text.Trim());
                ObjFormulario.URL1 = (Gv_Formularios.Rows[e.RowIndex].FindControl("TxtUrl") as TextBox).Text.Trim();
                ObjFormulario.ORDEN1 = int.Parse((Gv_Formularios.Rows[e.RowIndex].FindControl("TxtOrden") as TextBox).Text.Trim());
                labelexito.Text = ObjFormulario.UpdateFormulario();
                Gv_Formularios.EditIndex = -1;
                CargarFormuarios();

                labelerror.Text = "";
                
            }
            catch (Exception ex)
            {
                labelerror.Text = ex.Message;

                labelexito.Text = "";
            }

        }

        protected void Gv_Formularios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                Clases.BO_Formulario ObjFormulario = new Clases.BO_Formulario();
                ObjFormulario.FORMULARIO1 = Convert.ToInt32((Gv_Formularios.Rows[e.RowIndex].FindControl("LblFormulario") as Label).Text.Trim());
               
               labelexito.Text = ObjFormulario.DeleteFormulario();
                Gv_Formularios.EditIndex = -1;
                CargarFormuarios();
                labelerror.Text = "";
                

            }
            catch (Exception ex)
            {
                labelerror.Text = ex.Message;

                labelexito.Text = "";

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppG6_19
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool LoginCorrecto = false; string Mensaje = "";

                if (LoginCorrecto = Clases.Autenticacion.ValidaUsuario(UserName.Text.ToUpper(), Password.Text, out Mensaje))
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    Label1.Text = Mensaje;
                    UserName.Text = "";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}
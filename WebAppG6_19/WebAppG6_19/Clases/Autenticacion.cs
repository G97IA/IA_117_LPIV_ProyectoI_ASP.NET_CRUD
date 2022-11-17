using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace WebAppG6_19.Clases
{
    public class Autenticacion
    {
        public static bool ValidaUsuario (string User, string Password, out string Mensaje)
        {
            bool Autenticacion = false; Mensaje = "";

            BO_Usuario objUsuario = new BO_Usuario();
            var BOuser = objUsuario.GetUsuarioLogin(User);

            if(BOuser == null)
            {
                Mensaje = "Usuario No existe o Contraseña Incorrecta";
                Autenticacion = false;
            }
            else if (BOuser.Rows[0]["USER_CLAVE"].ToString() != Password)
            {
                Mensaje = "Usuario No Existe o Contraseña Incorrecta";
                Autenticacion = false;
            }
            else if (BOuser.Rows[0]["ESTADO"].ToString()[1] != 'A')
            {
                Mensaje = "Su usuario esta inactivo";
                Autenticacion=false;
            }
            else
            {
                Autenticacion = true;
            }

            return Autenticacion;
        }

    }
}
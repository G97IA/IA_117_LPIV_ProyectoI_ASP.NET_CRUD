using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services.Description;

namespace WebAppG6_19.Clases
{
    public class BO_Usuario
    {
        private string USUARIO;
        private string NOMBRES;
        private string APELLIDOS;
        private string CLAVE;
        private int ROL;
        private string ESTADO;
        private string CORREO;
        private DateTime FECHA;
        private string CREADO;

        public string USUARIO1   { get => USUARIO; set => USUARIO = value; }
        public string NOMBRES1   { get => NOMBRES; set => NOMBRES = value; }
        public string APELLIDOS1 { get => APELLIDOS; set => APELLIDOS = value; }
        public string CLAVE1     { get => CLAVE; set => CLAVE = value; }
        public int    ROL1       { get => ROL; set => ROL = value; }
        public string ESTADO1    { get => ESTADO; set => ESTADO = value; }
        public string CORREO1    { get => CORREO; set => CORREO = value; }
        public DateTime FECHA1   { get => FECHA; set => FECHA = value; }
        public string CREADO1    { get => CREADO; set => CREADO = value; }


        public DataTable GetUsuarioLogin(string UsuarioId)// Metodo DataTable para obtener el usuario al sistema.
        {
            using (OracleConnection objConn = new OracleConnection(ConnOracle.ConexionOracle())) //Establecer la conexion de oracle.
            {
                try
                {
                    objConn.Open(); //Abrir la conexion oracle.
                    OracleCommand objComando = new OracleCommand(); //Instanciar un comando oracle
                    objComando.Connection = objConn; //Establecer la coneccion al comando oracle
                    objComando.CommandText = "G6_19.SEGURIDAD.P_INGRESO_USUARIO"; //Indicar al comando el procedimiento ejecutara
                    objComando.CommandType = CommandType.StoredProcedure; // Indicar al comando que ejecutara un procedimiento
                    OracleParameter[] parm = new OracleParameter[2]; //Declara los parametros que necesita el procedimiento
                    parm[0] = objComando.Parameters.Add("P_USUARIO", OracleDbType.Varchar2, UsuarioId, ParameterDirection.Input); //Primer parametro
                    objComando.Parameters.Add("RESULTADO", OracleDbType.RefCursor).Direction = ParameterDirection.Output; // Segundo parametro
                    objComando.ExecuteNonQuery(); //Indicar al comando que no ejecutara un query
                    OracleDataAdapter da = new OracleDataAdapter(objComando); //Instanciar un DataAdapter
                    DataSet ds = new DataSet(); //Instanciar un DataSet
                    da.Fill(ds, "ID_USUARIO"); //Llenar el dataset con el resultado del dataAdapter

                    if (ds.Tables[0].Rows.Count > 0) //Evaluar el dataset devuelve un registro
                    {
                        return ds.Tables[0]; //Si es verdadero devolvemos una tabla

                    }
                    else
                    {
                        return null; //Si es falso devolvemos null
                    }
                }
                catch (OracleException ex) //Manejo de excepciones
                {
                    throw ex;
                }
            }
        }

        public DataTable GetUsuarios()
        {
            using (OracleConnection objConn = new OracleConnection(ConnOracle.ConexionOracle())) //Establecer la conexion de oracle.
            {
                try
                {
                    objConn.Open(); //Abrir la conexion oracle.
                    OracleCommand objComando = new OracleCommand(); //Instanciar un comando oracle
                    objComando.Connection = objConn; //Establecer la coneccion al comando oracle
                    objComando.CommandText = "G6_19.SEGURIDAD.P_GET_USUARIOS"; //Indicar al comando el procedimiento ejecutara
                    objComando.CommandType = CommandType.StoredProcedure; // Indicar al comando que ejecutara un procedimiento
                    OracleParameter[] parm = new OracleParameter[1]; //Declara los parametros que necesita el procedimiento
                    objComando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output; // Segundo parametro
                    objComando.ExecuteNonQuery(); //Indicar al comando que no ejecutara un query
                    OracleDataAdapter da = new OracleDataAdapter(objComando); //Instanciar un DataAdapter
                    DataSet ds = new DataSet(); //Instanciar un DataSet
                    da.Fill(ds, "ID_USUARIO"); //Llenar el dataset con el resultado del dataAdapter

                    if (ds.Tables[0].Rows.Count > 0) //Evaluar el dataset devuelve un registro
                    {
                        return ds.Tables[0]; //Si es verdadero devolvemos una tabla
                    }
                    else
                    {
                        return null; //Si es falso devolvemos null
                    }
                }
                catch (OracleException ex) //Manejo de excepciones
                {
                    throw ex;
                }
            }
        }

        public string UpdateUsuario()
        {
            using (OracleConnection objconn = new OracleConnection(ConnOracle.ConexionOracle()))
            {
                try
                {
                    objconn.Open();
                    OracleCommand objCommando = new OracleCommand();
                    objCommando.Connection = objconn;
                    objCommando.CommandText = "GP.SEGURIDAD.P_UPDATE_USUARIOS";
                    objCommando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[9];
                    parm[0] = objCommando.Parameters.Add("p_usuario", OracleDbType.Varchar2, USUARIO1, ParameterDirection.Input);
                    parm[1] = objCommando.Parameters.Add("p_nombres", OracleDbType.Varchar2, NOMBRES1, ParameterDirection.Input);
                    parm[2] = objCommando.Parameters.Add("p_apellidos", OracleDbType.Varchar2, APELLIDOS1, ParameterDirection.Input);
                    parm[3] = objCommando.Parameters.Add("p_user_clave", OracleDbType.Varchar2, CLAVE1, ParameterDirection.Input);
                    parm[4] = objCommando.Parameters.Add("p_rol", OracleDbType.Int32, ROL1, ParameterDirection.Input);
                    parm[5] = objCommando.Parameters.Add("p_estado", OracleDbType.Varchar2, ESTADO1, ParameterDirection.Input);
                    parm[6] = objCommando.Parameters.Add("p_correo", OracleDbType.Varchar2, CORREO1, ParameterDirection.Input);
                    parm[7] = objCommando.Parameters.Add("p_fecha", OracleDbType.TimeStamp, FECHA1, ParameterDirection.Input);
                    parm[8] = objCommando.Parameters.Add("p_creado", OracleDbType.Varchar2, CREADO1, ParameterDirection.Input);
                    objCommando.ExecuteNonQuery();
                    objconn.Close();

                    return "Usuario Actualizado";

                }
                catch (OracleException Ex)
                {

                    throw Ex;

                }
            }
        }

        public string DeleteUsuario()
        {
            using (OracleConnection objconn = new OracleConnection(ConnOracle.ConexionOracle()))
            {
                try
                {
                    objconn.Open();
                    OracleCommand objCommando = new OracleCommand();
                    objCommando.Connection = objconn;
                    objCommando.CommandText = "GP.SEGURIDAD.P_DELETE_USUARIOS";
                    objCommando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[1];
                    parm[0] = objCommando.Parameters.Add("p_usuario", OracleDbType.Varchar2, USUARIO1, ParameterDirection.Input);
                    
                    objCommando.ExecuteNonQuery();
                    objconn.Close();

                    return "Usuario Eliminado";

                }
                catch (OracleException Ex)
                {

                    throw Ex;

                }
            }
        }

        public string InsertUsuario()
        {
            using (OracleConnection objConn = new OracleConnection(ConnOracle.ConexionOracle()))
            {
              try
              {
                    objConn.Open(); //Abrir la conexion oracle.
                    OracleCommand objComando = new OracleCommand(); //Instanciar un comando oracle
                    objComando.Connection = objConn; //Establecer la coneccion al comando oracle
                    objComando.CommandText = "GP.SEGURIDAD.P_INSERT_USUARIOS"; //Indicar al comando el procedimiento ejecutara
                    objComando.CommandType = CommandType.StoredProcedure; // Indicar al comando que ejecutara un procedimiento
                    OracleParameter[] parm = new OracleParameter[9]; //Declara los parametros que necesita el procedimiento
                    parm[0] = objComando.Parameters.Add("p_usuario", OracleDbType.Varchar2, USUARIO1, ParameterDirection.Input); 
                    parm[1] = objComando.Parameters.Add("p_nombres", OracleDbType.Varchar2, NOMBRES1, ParameterDirection.Input);
                    parm[2] = objComando.Parameters.Add("p_apellidos", OracleDbType.Varchar2, APELLIDOS1, ParameterDirection.Input);
                    parm[3] = objComando.Parameters.Add("p_user_clave", OracleDbType.Varchar2, CLAVE1, ParameterDirection.Input);
                    parm[4] = objComando.Parameters.Add("p_rol", OracleDbType.Int32, ROL1, ParameterDirection.Input);
                    parm[5] = objComando.Parameters.Add("p_estado", OracleDbType.Varchar2, ESTADO1, ParameterDirection.Input);
                    parm[6] = objComando.Parameters.Add("p_correo", OracleDbType.Varchar2, CORREO1, ParameterDirection.Input);
                    parm[7] = objComando.Parameters.Add("p_fecha", OracleDbType.TimeStamp, FECHA1, ParameterDirection.Input);
                    parm[8] = objComando.Parameters.Add("p_creado", OracleDbType.Varchar2, CREADO1, ParameterDirection.Input);
                    objComando.ExecuteNonQuery(); //Indicar al comando que no ejecutara un query
                    objConn.Close();

                    return "Usuario Actualizado";

              }
              catch (OracleException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
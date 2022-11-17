using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAppG6_19.Clases
{
    public class BO_Formulario
    {
        private int FORMULARIO;
        private string TECNICO;
        private string VISTA;
        private int MENU;
        private string URL;
        private int ORDEN;


        public int FORMULARIO1 { get => FORMULARIO; set => FORMULARIO = value; }
        public string TECNICO1 { get => TECNICO; set => TECNICO = value; }
        public string VISTA1 { get => VISTA; set => VISTA = value; }
        public int MENU1 { get => MENU; set => MENU = value; }
        public string URL1 { get => URL; set => URL = value; }
        public int ORDEN1 { get => ORDEN; set => ORDEN = value; }




        public DataTable GetFormulario()
        {
            using (OracleConnection objconn = new OracleConnection(ConnOracle.ConexionOracle())) //establece conexion con la base de datos

            {
                try
                {
                    objconn.Open();//abrir la conexion oracle
                    OracleCommand objCommando = new OracleCommand();//instanciar un comando oracle
                    objCommando.Connection = objconn;
                    objCommando.CommandText = "G6_19.SEGURIDAD.P_GET_FORMULARIOS";//INDICAR AL COMANDO EL PROCEDIMIENDO QUE 
                    objCommando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[1];
                    objCommando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    objCommando.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(objCommando);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ID_FORMULARIO");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (OracleException ex)
                {
                    throw ex;
                }
            }
        }


        public string UpdateFormulario()
        {
            using (OracleConnection objconn = new OracleConnection(ConnOracle.ConexionOracle())) //establece conexion con la base de datos
            {
                try
                {
                    objconn.Open();//abrir la conexion oracle
                    OracleCommand objCommando = new OracleCommand();//instanciar un comando oracle
                    objCommando.Connection = objconn;
                    objCommando.CommandText = "G6_19.SEGURIDAD.P_UPDATE_FORMULARIOS";//INDICAR AL COMANDO EL PROCEDIMIENDO QUE 
                    objCommando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[6];
                    parm[0] = objCommando.Parameters.Add("p_formulario", OracleDbType.Int32, FORMULARIO1, ParameterDirection.Input);
                    parm[1] = objCommando.Parameters.Add("p_nombre_tecnico", OracleDbType.Varchar2, TECNICO1, ParameterDirection.Input);
                    parm[2] = objCommando.Parameters.Add("p_nombre_vista", OracleDbType.Varchar2, VISTA1, ParameterDirection.Input);
                    parm[3] = objCommando.Parameters.Add("p_id_menu", OracleDbType.Int32, MENU1, ParameterDirection.Input);
                    parm[4] = objCommando.Parameters.Add("p_url", OracleDbType.Varchar2, URL1, ParameterDirection.Input);
                    parm[5] = objCommando.Parameters.Add("p_orden", OracleDbType.Int32, ORDEN1, ParameterDirection.Input);
                    objCommando.ExecuteNonQuery();
                    objconn.Close();
                    return "Formulario Actualizado";
                }
                catch (OracleException ex)
                {
                    throw ex;
                    
                }



            }
        }

        public string InsertFormulario()
        {
            using (OracleConnection objconn = new OracleConnection(ConnOracle.ConexionOracle())) //establece conexion con la base de datos

            {
                try
                {
                    objconn.Open();//abrir la conexion oracle
                    OracleCommand objCommando = new OracleCommand();//instanciar un comando oracle
                    objCommando.Connection = objconn;
                    objCommando.CommandText = "G6_19.SEGURIDAD.P_INSERT_FORMULARIOS";//INDICAR AL COMANDO EL PROCEDIMIENDO QUE 
                    objCommando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[6];
                    parm[0] = objCommando.Parameters.Add("p_formulario", OracleDbType.Int32, FORMULARIO1, ParameterDirection.Input);
                    parm[1] = objCommando.Parameters.Add("p_nombre_tecnico", OracleDbType.Varchar2, TECNICO1, ParameterDirection.Input);
                    parm[2] = objCommando.Parameters.Add("p_nombre_vista", OracleDbType.Varchar2, VISTA1, ParameterDirection.Input);
                    parm[3] = objCommando.Parameters.Add("p_id_menu", OracleDbType.Int32, MENU1, ParameterDirection.Input);
                    parm[4] = objCommando.Parameters.Add("p_url", OracleDbType.Varchar2, URL1, ParameterDirection.Input);
                    parm[5] = objCommando.Parameters.Add("p_orden", OracleDbType.Int32, ORDEN1, ParameterDirection.Input);
                    objCommando.ExecuteNonQuery();
                    objconn.Close();
                    return "Formulario Ingresado";

                }
                catch (OracleException ex)
                {
                    throw ex;
                }
            }

        }


        public string DeleteFormulario()
        {
            using (OracleConnection objconn = new OracleConnection(ConnOracle.ConexionOracle()))
            {
                try
                {
                    objconn.Open();
                    OracleCommand objCommando = new OracleCommand();
                    objCommando.Connection = objconn;
                    objCommando.CommandText = "G6_19.SEGURIDAD.P_DELETE_FORMULARIOS";
                    objCommando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[1];
                    parm[0] = objCommando.Parameters.Add("p_formulario", OracleDbType.Varchar2, FORMULARIO1, ParameterDirection.Input);

                    objCommando.ExecuteNonQuery();
                    objconn.Close();

                    return "Formulario Eliminado";

                }
                catch (OracleException Ex)
                {

                    throw Ex;

                }


            }



        }







    }
}
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAppG6_19.Clases
{
    public class BO_Roles
    {
        private string ID_ROL;
        private string DESCRIPCION;
        private string MODULO;
        private string ESTADO;
        private DateTime CREACION;
        public string ID_ROL1 { get => ID_ROL; set => ID_ROL=value; }
        public string DESCRIPCION1 { get => DESCRIPCION; set => DESCRIPCION=value; }
        public string MODULO1 { get => MODULO; set => MODULO=value; }
        public string ESTADO1 { get => ESTADO; set => ESTADO=value; }
        public DateTime CREACION1 { get => CREACION; set => CREACION=value; }

        public DataTable GetRoles()
        {
            using (OracleConnection objConn = new OracleConnection(ConnOracle.ConexionOracle())) //Establecer la conexion de oracle.
            {
                try
                {
                    objConn.Open(); //Abrir la conexion oracle.
                    OracleCommand objComando = new OracleCommand(); //Instanciar un comando oracle
                    objComando.Connection = objConn; //Establecer la coneccion al comando oracle
                    objComando.CommandText = "G6_19.SEGURIDAD.P_GET_ROLES"; //Indicar al comando el procedimiento ejecutara
                    objComando.CommandType = CommandType.StoredProcedure; // Indicar al comando que ejecutara un procedimiento
                    OracleParameter[] parm = new OracleParameter[1]; //Declara los parametros que necesita el procedimiento              
                    objComando.Parameters.Add("RESULTADO", OracleDbType.RefCursor).Direction = ParameterDirection.Output; // Segundo parametro
                    objComando.ExecuteNonQuery(); //Indicar al comando que no ejecutara un query
                    OracleDataAdapter da = new OracleDataAdapter(objComando); //Instanciar un DataAdapter
                    DataSet ds = new DataSet(); //Instanciar un DataSet
                    da.Fill(ds, "ID_ROL"); //Llenar el dataset con el resultado del dataAdapter

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

        public string InsertRol()
        {
            using (OracleConnection objConn = new OracleConnection(ConnOracle.ConexionOracle()))
            {
                try
                {
                    objConn.Open(); //Abrir la conexion oracle.
                    OracleCommand objComando = new OracleCommand(); //Instanciar un comando oracle
                    objComando.Connection = objConn; //Establecer la coneccion al comando oracle
                    objComando.CommandText = "G6_19.SEGURIDAD.P_INSERT_ROLES"; //Indicar al comando el procedimiento ejecutara
                    objComando.CommandType = CommandType.StoredProcedure; // Indicar al comando que ejecutara un procedimiento
                    OracleParameter[] parm = new OracleParameter[5]; //Declara los parametros que necesita el procedimiento
                    parm[0] = objComando.Parameters.Add("P_ROL", OracleDbType.Varchar2, ID_ROL1, ParameterDirection.Input);
                    parm[1] = objComando.Parameters.Add("P_DESCRIPCION", OracleDbType.Varchar2, DESCRIPCION1, ParameterDirection.Input);
                    parm[2] = objComando.Parameters.Add("P_MODULO", OracleDbType.Varchar2, MODULO1, ParameterDirection.Input);
                    parm[3] = objComando.Parameters.Add("P_ESTADO", OracleDbType.Varchar2, ESTADO1, ParameterDirection.Input);
                    parm[4] = objComando.Parameters.Add("P_CREACION", OracleDbType.Date, CREACION1, ParameterDirection.Input);
                    
                    objComando.ExecuteNonQuery(); //Indicar al comando que no ejecutara un query
                    objConn.Close();

                    return "Rol Insertado";
                }
                catch (OracleException ex)
                {
                    throw ex;
                }
            }

        }

        public string UpdateRol()
        {
            using (OracleConnection objConn = new OracleConnection(ConnOracle.ConexionOracle()))
            {
                try
                {
                    objConn.Open();
                    OracleCommand objComando = new OracleCommand();
                    objComando.Connection = objConn;
                    objComando.CommandText = "G6_19.SEGURIDAD.P_UPDATE_ROLES";
                    objComando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[5];
                    parm[0] = objComando.Parameters.Add("P_ROL", OracleDbType.Varchar2, ID_ROL1, ParameterDirection.Input);
                    parm[1] = objComando.Parameters.Add("P_DESCRIPCION", OracleDbType.Varchar2, DESCRIPCION1, ParameterDirection.Input);
                    parm[2] = objComando.Parameters.Add("P_MODULO", OracleDbType.Varchar2, MODULO1, ParameterDirection.Input);
                    parm[3] = objComando.Parameters.Add("P_ESTADO", OracleDbType.Varchar2, ESTADO1, ParameterDirection.Input);
                    parm[4] = objComando.Parameters.Add("P_CREACION", OracleDbType.Date, CREACION1, ParameterDirection.Input);
                    objComando.ExecuteNonQuery();
                    objConn.Close();

                    return "Rol Actualizado";

                }
                catch (OracleException ex)
                {
                    throw ex;
                }
            }
        }

        public string DeleteRol()
        {
            using (OracleConnection objConn = new OracleConnection(ConnOracle.ConexionOracle()))
            {
                try
                {
                    objConn.Open();
                    OracleCommand objComando = new OracleCommand();
                    objComando.Connection = objConn;
                    objComando.CommandText = "G6_19.SEGURIDAD.P_DELETE_ROLES";
                    objComando.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parm = new OracleParameter[1]; 
                    parm[0] = objComando.Parameters.Add("P_ROL", OracleDbType.Varchar2, ID_ROL1, ParameterDirection.Input);
                    objComando.ExecuteNonQuery();
                    objConn.Close();

                    return "Rol Eliminado";

                }
                catch (OracleException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
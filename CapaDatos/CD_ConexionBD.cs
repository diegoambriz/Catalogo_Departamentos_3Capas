using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_ConexionBD
    {
        SqlConnection _sqlCnx = new SqlConnection("Server=4FL2OJI\\SQLEXPRESS;DataBase=Ejemplo1;Integrated Security=Yes");

        //Método para abrir Conexión BD
        public void abrir_conexion()
        {
            if (_sqlCnx.State == ConnectionState.Closed)
            {
                try
                {
                    _sqlCnx.Open();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                
            }
        }

        //Método para cerrar Conexión BD
        public void cerrar_conexion()
        {
            if (_sqlCnx.State == ConnectionState.Open)
            {
                _sqlCnx.Close();
            }
        }


        //Método para ejecutar sp (Insert, Delete, Update)
        public void Ejecutar_Sp(String NombreSp, List<CD_Parametro> lst)
        {
            SqlCommand cmd;
            try
            {
                abrir_conexion();
                cmd = new SqlCommand(NombreSp, _sqlCnx);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].m_Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].m_Nombre, lst[i].m_Valor);
                        }

                        if (lst[i].m_Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].m_Nombre, lst[i].m_TipoDato, lst[i].m_Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].m_Valor = cmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            cerrar_conexion();
        }

        //Método para los listados o Consultas (Select)
        public DataTable Consulta_Datos(String NombreSP, List<CD_Parametro> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                abrir_conexion();
                da = new SqlDataAdapter(NombreSP, _sqlCnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].m_Nombre, lst[i].m_Valor);
                    }
                }
                da.Fill(dt); //Llenamos el dt con los datos del da
            }
            catch (Exception ex)
            {

                throw ex;
            }
            cerrar_conexion();
            return dt;
        }
    }
}
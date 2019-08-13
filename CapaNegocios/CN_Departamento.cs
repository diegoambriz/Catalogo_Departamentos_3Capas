using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Departamento
    {    
        //Atributos
        public Int32 Id_Ofi { get; set; }
        public Int32 Id_Depto { get; set; }
        public String Depto_Descripcion { get; set; }
        public Boolean Depto_Activo { get; set; }
        public String Depto_ActivoStr { get; set; }

        //Agregamos referencia al ClsManejador
        CD_ConexionBD cnx = new CD_ConexionBD();  

        public String Insertar_Departamento()
        {
            String msj = "";
            List<CD_Parametro> lst = new List<CD_Parametro>();

            try
            {
                //Pasamos los parametros de Entrada
                lst.Add(new CD_Parametro("@Id_Ofi", Id_Ofi));
                lst.Add(new CD_Parametro("@Depto_Descripcion", Depto_Descripcion));
                lst.Add(new CD_Parametro("@Depto_Activo", Depto_Activo));
                
                //Pasamos el parametro de Salida
                lst.Add(new CD_Parametro("@Mensaje", SqlDbType.VarChar, 100));

                cnx.Ejecutar_Sp("spCatDepartamento_Insertar", lst);
                msj = lst[3].m_Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        public String Modificar_Departamento()
        {
            String msj = "";
            List<CD_Parametro> lst = new List<CD_Parametro>();

            try
            {
                //Pasamos los parametros de Entrada
                lst.Add(new CD_Parametro("@Id_Depto", Id_Depto));
                lst.Add(new CD_Parametro("@Id_Ofi", Id_Ofi));
                lst.Add(new CD_Parametro("@Depto_Descripcion", Depto_Descripcion));
                lst.Add(new CD_Parametro("@Depto_Activo", Depto_Activo));

                //Pasamos el parametro de Salida
                lst.Add(new CD_Parametro("@Mensaje", SqlDbType.VarChar, 100));

                cnx.Ejecutar_Sp("spCatDepartamento_Modificar", lst);
                msj = lst[4].m_Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        //Metodo para mostrar Departamentos
        public DataTable Consulta_Departamentos()
        {
            return cnx.Consulta_Datos("spCatDepartamento_Consulta", null);
        }
    }
}
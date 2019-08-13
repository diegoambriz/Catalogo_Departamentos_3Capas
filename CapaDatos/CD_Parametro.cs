using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaDatos
{
    public class CD_Parametro
    {
        //Parámetros
        public String m_Nombre { get; set; }
        public Object m_Valor { get; set; }
        public SqlDbType m_TipoDato { get; set; }
        public Int32 m_Tamaño { get; set; }
        public ParameterDirection m_Direccion { get; set; }

        //CONSTRUCTORES
        //Parámetros de Entrada
        public CD_Parametro(String objNombre, Object objValor)
        {
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_Direccion = ParameterDirection.Input;
        }

        //Parámetros de Salida
        public CD_Parametro(String objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            m_Nombre = objNombre;
            m_TipoDato = objTipoDato;
            m_Tamaño = objTamaño;
            m_Direccion = ParameterDirection.Output;
        }
    }
}

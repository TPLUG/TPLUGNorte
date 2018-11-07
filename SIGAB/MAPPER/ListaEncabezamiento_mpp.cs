using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Data.SqlClient;
using ENTIDADES;

namespace MAPPER
{
    public class ListaEncabezamiento_mpp
    {
        public int Agregar(ListaEncabezamiento_en encabezadoEntidad)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_encabezamiento", encabezadoEntidad.codEncabezamiento };
            object[] param2 = { "@detalle", encabezadoEntidad.detalle };
            parametros.Add(param1);
            parametros.Add(param2);
            return sql.EjecutarSP_int("Lista_Encabezamiento_Agregar", parametros);
        }
        public int Borrar(int id)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_encabezamiento", id };           
            parametros.Add(param1);
            return sql.EjecutarSP_int("Lista_Encabezamiento_Agregar", parametros);
        }

        public ListaEncabezamiento_en Traer(int id)
        {
            ListaEncabezamiento_en encabezado = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Operador_Traer"/*,id*/);
            if (dr.Read())
            {
                encabezado = new ListaEncabezamiento_en();
                encabezado.codEncabezamiento = Convert.ToInt32(dr["cod_encabezamiento"]);
                encabezado.detalle = dr["detalle"].ToString();
            }
            return encabezado;
        }
        public List<ListaEncabezamiento_en> TraerTodo()
        {
            List<ListaEncabezamiento_en> listaEncabezados = new List<ListaEncabezamiento_en>();
            ListaEncabezamiento_en encabezado = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_Encabezamiento_TraerTodos");
            if (dr.Read())
            {
                encabezado = new ListaEncabezamiento_en();
                encabezado.codEncabezamiento = Convert.ToInt32(dr["cod_encabezamiento"]);
                encabezado.detalle = dr["detalle"].ToString();
                listaEncabezados.Add(encabezado);
            }
            return listaEncabezados;
        }
    }
}

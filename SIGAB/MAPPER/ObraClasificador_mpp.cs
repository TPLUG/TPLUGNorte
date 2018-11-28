using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DAL;
using System.Data.SqlClient;

namespace MAPPER
{
    public class ObraClasificador_mpp
    {
        public int Agregar(ObraClasificador_en ObraClasificador)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_ObraClasificador", ObraClasificador.codObraClasificador };
            object[] param2 = { "@detalle", ObraClasificador.detalle };
            parametros.Add(param1);
            parametros.Add(param2);
            return sql.EjecutarSP_int("ObraClasificador_Agregar", parametros);
        }
        public int Borrar(int id)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_ObraClasificador", id };
            parametros.Add(param1);
            return sql.EjecutarSP_int("ObraClasificador_Borrar", parametros);
        }

        public ObraClasificador_en Traer(int id)
        {
            ObraClasificador_en ObraClasificador = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Operador_Traer"/*,id*/);
            if (dr.Read())
            {
                ObraClasificador = new ObraClasificador_en();
                ObraClasificador.codObraClasificador = Convert.ToInt32(dr["cod_ObraClasificador"]);
                ObraClasificador.detalle = dr["detalle"].ToString();
            }
            return ObraClasificador;
        }
        public List<ObraClasificador_en> TraerTodo()
        {
            List<ObraClasificador_en> ObraClasificadores = new List<ObraClasificador_en>();
            ObraClasificador_en ObraClasificador = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("ObraClasificador_TraerTodos");
            if (dr.Read())
            {
                ObraClasificador = new ObraClasificador_en();
                ObraClasificador.codObraClasificador = Convert.ToInt32(dr["cod_ObraClasificador"]);
                ObraClasificador.detalle = dr["detalle"].ToString();
                ObraClasificadores.Add(ObraClasificador);
            }
            return ObraClasificadores;
        }
    }
}

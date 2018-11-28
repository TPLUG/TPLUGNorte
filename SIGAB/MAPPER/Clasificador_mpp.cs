using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTIDADES;
using System.Data.SqlClient;

namespace MAPPER
{
    public class Clasificador_mpp
    {
        public int Agregar(Clasificador_en Clasificador)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_Clasificador", Clasificador.codClasificador };
            object[] param2 = { "@detalle", Clasificador.detalle };
            parametros.Add(param1);
            parametros.Add(param2);
            return sql.EjecutarSP_int("Clasificador_Agregar", parametros);
        }
        public int Borrar(int id)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_Clasificador", id };
            parametros.Add(param1);
            return sql.EjecutarSP_int("Clasificador_Borrar", parametros);
        }

        public Clasificador_en Traer(int id)
        {
            Clasificador_en Clasificador = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Operador_Traer"/*,id*/);
            if (dr.Read())
            {
                Clasificador = new Clasificador_en();
                Clasificador.codClasificador = Convert.ToInt32(dr["cod_Clasificador"]);
                Clasificador.detalle = dr["detalle"].ToString();
            }
            return Clasificador;
        }
        public List<Clasificador_en> TraerTodo()
        {
            List<Clasificador_en> Clasificadores = new List<Clasificador_en>();
            Clasificador_en Clasificador = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Clasificador_TraerTodos");
            if (dr.Read())
            {
                Clasificador = new Clasificador_en();
                Clasificador.codClasificador = Convert.ToInt32(dr["cod_Clasificador"]);
                Clasificador.detalle = dr["detalle"].ToString();
                Clasificadores.Add(Clasificador);
            }
            return Clasificadores;
        }
    }
}

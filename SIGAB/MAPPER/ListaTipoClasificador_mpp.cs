using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDADES;
using DAL;

namespace MAPPER
{
    public class ListaTipoClasificador_mpp
    {
        public int Agregar(ListaTipoClasificador_en tipoClasificador)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_tipoClasificador", tipoClasificador.codTipoClasificador };
            object[] param2 = { "@detalle", tipoClasificador.detalle };
            parametros.Add(param1);
            parametros.Add(param2);
            return sql.EjecutarSP_int("ListaTipoClasificador_Agregar", parametros);
        }
        public int Borrar(int id)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_tipoClasificador", id };
            parametros.Add(param1);
            return sql.EjecutarSP_int("ListaTipoClasificador_Borrar", parametros);
        }

        public ListaTipoClasificador_en Traer(int id)
        {
            ListaTipoClasificador_en tipoClasificador = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Operador_Traer"/*,id*/);
            if (dr.Read())
            {
                tipoClasificador = new ListaTipoClasificador_en();
                tipoClasificador.codTipoClasificador = Convert.ToInt32(dr["cod_tipoClasificador"]);
                tipoClasificador.detalle = dr["detalle"].ToString();
            }
            return tipoClasificador;
        }
        public List<ListaTipoClasificador_en> TraerTodo()
        {
            List<ListaTipoClasificador_en> listatipoClasificadors = new List<ListaTipoClasificador_en>();
            ListaTipoClasificador_en tipoClasificador = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("ListaTipoClasificador_TraerTodos");
            if (dr.Read())
            {
                tipoClasificador = new ListaTipoClasificador_en();
                tipoClasificador.codTipoClasificador = Convert.ToInt32(dr["cod_tipoClasificador"]);
                tipoClasificador.detalle = dr["detalle"].ToString();
                listatipoClasificadors.Add(tipoClasificador);
            }
            return listatipoClasificadors;
        }
    }
}

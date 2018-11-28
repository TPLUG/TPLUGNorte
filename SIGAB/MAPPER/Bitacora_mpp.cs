using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using ENTIDADES;

namespace MAPPER
{
    public class Bitacora_mpp
    {
        public int Agregar(Bitacora_en Bitacora)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_Bitacora", Bitacora.codBitacora };
            object[] param2 = { "@detalle", Bitacora.detalle };
            parametros.Add(param1);
            parametros.Add(param2);
            return sql.EjecutarSP_int("Bitacora_Agregar", parametros);
        }
        public int Borrar(int id)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_Bitacora", id };
            parametros.Add(param1);
            return sql.EjecutarSP_int("Bitacora_Borrar", parametros);
        }

        public Bitacora_en Traer(int id)
        {
            Bitacora_en Bitacora = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Operador_Traer"/*,id*/);
            if (dr.Read())
            {
                Bitacora = new Bitacora_en();
                Bitacora.codBitacora = Convert.ToInt32(dr["cod_Bitacora"]);
                Bitacora.detalle = dr["detalle"].ToString();
            }
            return Bitacora;
        }
        /*public List<Bitacora_en> TraerTodo()
        {
            List<Bitacora_en> Bitacoras = new List<Bitacora_en>();
            Bitacora_en Bitacora = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Bitacora_TraerTodos");
            if (dr.Read())
            {
                Bitacora = new Bitacora_en();
                bitacora.codBitacora = Convert.ToInt32(dr["cod_bitacora"]);
                bitacora.detalle = dr["detalle"].ToString();
                Bitacoras.Add(bitacora);
            }
            return Bitacoras;
        }*/
    }
}

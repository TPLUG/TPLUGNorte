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
    public class Coleccion_mpp
    {
        public Coleccion_en Traer(int id)
        {
            Coleccion_en m = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_TipoColeccion_Traer");

            if (dr.Read())
            {
                m = new Coleccion_en();
                m.codigo = Convert.ToInt32(dr["cod_coleccion"]);
                m.detalle = dr["detalle"].ToString();
            }

            return m;
        }

        public List<Coleccion_en> TraerTodos()
        {
            List<Coleccion_en> monedas = new List<Coleccion_en>();
            Coleccion_en coleccion;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_TipoColeccion_TraerTodos");

            while (dr.Read())
            {
                coleccion = new Coleccion_en();
                coleccion.codigo = Convert.ToInt32(dr["cod_coleccion"]);
                coleccion.detalle = dr["detalle"].ToString();
                monedas.Add(coleccion);
            }

            return monedas;
        }
    }
}

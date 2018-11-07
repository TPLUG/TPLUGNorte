using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data.SqlClient;
using DAL;

namespace MAPPER
{
    public class Soporte_mpp
    {
        public Soporte_en Traer(int id)
        {
            Soporte_en s = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_soporte_Traer");
            if (dr.Read())
            {
                s = new Soporte_en();
                s.cod_soporte = Convert.ToInt32(dr["cod_soporte"]);
                s.detalle = dr["detalle"].ToString();
                s.reproduccion = Convert.ToInt32(dr["reproduccion"]);
                s.icono= dr["icono"].ToString();
            }

            return s;
        }

        public List<Soporte_en> TraerTodos()
        {
            List<Soporte_en> soportes = new List<Soporte_en>();
            Soporte_en soporte;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_soporte_TraerTodos");
            while (dr.Read())
            {
                soporte = new Soporte_en();
                soporte.cod_soporte = Convert.ToInt32(dr["cod_soporte"]);
                soporte.detalle = dr["detalle"].ToString();
                soporte.reproduccion = Convert.ToInt32(dr["reproduccion"]);
                soporte.icono = dr["icono"].ToString();

                soportes.Add(soporte);
            }

            return soportes;
        }
    }
}

using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER
{
    public class Moneda_mpp
    {
        public Moneda_en Traer(int id)
        {
            Moneda_en m = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_moneda_Traer");
            if (dr.Read())
            {
                m = new Moneda_en();
                m.codigo = Convert.ToInt32(dr["cod_moneda"]);
                m.detalle = dr["detalle"].ToString();
            }

            return m;
        }

        public List<Moneda_en> TraerTodos()
        {
            List<Moneda_en> monedas = new List<Moneda_en>();
            Moneda_en moneda;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_moneda_TraerTodos");
            while (dr.Read())
            {
                moneda = new Moneda_en();
                moneda.codigo = Convert.ToInt32(dr["cod_moneda"]);
                moneda.detalle = dr["detalle"].ToString();
                monedas.Add(moneda);
            }

            return monedas;
        }
    }
}

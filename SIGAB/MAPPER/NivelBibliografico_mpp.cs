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
    public class NivelBibliografico_mpp
    {
        public NivelBibliografico_en Traer(int id)
        {
            NivelBibliografico_en nivel = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_nivel_bibliografico_Traer");
            if (dr.Read())
            {
                nivel = new NivelBibliografico_en();
                nivel.codigo = Convert.ToInt32(dr["cod_nivel_bibliografico"]);
                nivel.detalle = dr["detalle"].ToString();
            }

            return nivel;
        }

        public List<NivelBibliografico_en> TraerTodos()
        {
            List<NivelBibliografico_en> niveles = new List<NivelBibliografico_en>();
            NivelBibliografico_en nivel;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Lista_nivel_bibliografico_TraerTodos");
            while (dr.Read())
            {
                nivel = new NivelBibliografico_en();
                nivel.codigo = Convert.ToInt32(dr["cod_nivel_bibliografico"]);
                nivel.detalle = dr["detalle"].ToString();
                niveles.Add(nivel);
            }

            return niveles;
        }
    }
}

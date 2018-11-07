using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTIDADES;

namespace MAPPER
{
    public class Pais_mpp
    {
        public int Agregar(Pais_en p)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_pais", p.codPais };
            object[] param2 = { "@detalle", p.detalle };
            parametros.Add(param1);
            parametros.Add(param2);
            return sql.EjecutarSP_int("Pais_Agregar", parametros);
        }

        public int Borrar(Pais_en p)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_pais", p.codPais };
            parametros.Add(param1);
            return sql.EjecutarSP_int("Pais_Borrar", parametros);
        }

        public Pais_en Traer(int id)
        {
            Pais_en p = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Pais_Traer");
            if (dr.Read())
            {
                p = new Pais_en();
                p.codPais = Convert.ToInt32(dr["cod_pais"]);
                p.detalle = dr["detalle"].ToString();
            }            

            return p;
        }

        public List<Pais_en> TraerTodos()
        {
            List<Pais_en> paises = new List<Pais_en>();
            Pais_en pais;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Pais_TraerTodos");
            while (dr.Read())
            {
                pais = new Pais_en();
                pais.codPais = Convert.ToInt32(dr["cod_pais"]);
                pais.detalle = dr["detalle"].ToString();
                paises.Add(pais);
            }

            return paises;
        }
    }
}

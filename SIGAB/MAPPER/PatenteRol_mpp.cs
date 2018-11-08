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
    public class PatenteRol_mpp
    {
        public int Agregar(PatenteRol_en pr)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_rol", pr.cod_rol };
            object[] param2 = { "@cod_patente", pr.cod_patente };
            object[] param3 = { "@cod_habilitado", pr.cod_habilitado };
            parametros.Add(param1);
            parametros.Add(param2);
            parametros.Add(param3);

            return sql.EjecutarSP_int("PatenteRol_Agregar", parametros);
        }

        public PatenteRol_en Traer(int id)
        {
            PatenteRol_en patenteRol = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("PatenteRol_Traer");

            if (dr.Read())
            {
                patenteRol = new PatenteRol_en();
                patenteRol.cod_rol = Convert.ToInt32(dr["cod_rol"]);
                patenteRol.cod_patente = Convert.ToInt32(dr["cod_patente"]);
                patenteRol.cod_habilitado = Convert.ToInt32(dr["cod_habilitado"]);
            }
            return patenteRol;
        }

        public List<PatenteRol_en> TraerTodos()
        {
            List<PatenteRol_en> PatenteRoles = new List<PatenteRol_en>();
            PatenteRol_en patenteRol;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("PatenteRol_TraerTodos");

            while (dr.Read())
            {
                patenteRol = new PatenteRol_en();
                patenteRol.cod_rol = Convert.ToInt32(dr["cod_rol"]);
                patenteRol.cod_patente = Convert.ToInt32(dr["cod_patente"]);
                patenteRol.cod_habilitado = Convert.ToInt32(dr["cod_habilitado"]);
                PatenteRoles.Add(patenteRol);
            }
            return PatenteRoles;
        }

        public int Borrar(PatenteRol_en pr)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_rol", pr.cod_rol};
            object[] param2 = { "@cod_patente", pr.cod_patente };
            parametros.Add(param1);
            parametros.Add(param2);

            return sql.EjecutarSP_int("PatenteRol_Borrar", parametros);
        }
    }
}
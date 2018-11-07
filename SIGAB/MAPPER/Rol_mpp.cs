using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using ENTIDADES;

namespace MAPPER
{
    public class Rol_mpp
    {
        public int Agregar(Rol_en r)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_rol", r.codRol };
            object[] param2 = { "@detalle", r.detalle };
            parametros.Add(param1);
            parametros.Add(param2);

            return sql.EjecutarSP_int("Rol_Agregar", parametros);
        }

        public Rol_en Traer(int id)
        {
            Rol_en r = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Rol_Traer");

            if (dr.Read())
            {
                r = new Rol_en();
                r.codRol = Convert.ToInt32(dr["cod_rol"]);
                r.detalle = dr["detalle"].ToString();
            }
            return r;
        }

        public List<Rol_en> TraerTodos()
        {
            List<Rol_en> roles = new List<Rol_en>();
            Rol_en rol;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Rol_TraerTodos");

            while (dr.Read())
            {
                rol = new Rol_en();
                rol.codRol = Convert.ToInt32(dr["cod_rol"]);
                rol.detalle = dr["detalle"].ToString();
                roles.Add(rol);
            }
            return roles;
        }
        public int Borrar(Rol_en r)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_rol", r.codRol};
            parametros.Add(param1);

            return sql.EjecutarSP_int("Rol_Borrar", parametros);
        }
    }
}

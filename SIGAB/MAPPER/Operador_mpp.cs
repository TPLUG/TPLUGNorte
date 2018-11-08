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
    public class Operador_mpp
    {
        public int Agregar(Operador_en o)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_operador", o.cod_operador };
            object[] param2 = { "@email", o.email };
            object[] param3 = { "@password", o.password };
            object[] param4 = { "@cod_habilitado", o.cod_habilitado };
            object[] param5 = { "@cod_rol", o.cod_rol};
            parametros.Add(param1);
            parametros.Add(param2);
            parametros.Add(param3);
            parametros.Add(param4);
            parametros.Add(param5);

            return sql.EjecutarSP_int("Operador_Agregar", parametros);
        }

        public Operador_en Traer(int id)
        {
            Operador_en operador = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Operador_Traer");

            if (dr.Read())
            {
                operador = new Operador_en();
                operador.cod_operador = Convert.ToInt32(dr["cod_operador"]);
                operador.email = dr["email"].ToString();
                operador.password = dr["password"].ToString();
                operador.cod_habilitado = Convert.ToInt32(dr["cod_habilitado"]);
                operador.cod_rol = Convert.ToInt32(dr["cod_rol"]);
            }
            return operador;
        }

        public List<Operador_en> TraerTodos()
        {
            List<Operador_en> operadores = new List<Operador_en>();
            Operador_en operador;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Operador_TraerTodos");

            while (dr.Read())
            {
                operador = new Operador_en();
                operador.cod_operador = Convert.ToInt32(dr["cod_operador"]);
                operador.email = dr["email"].ToString();
                operador.password = dr["password"].ToString();
                operador.cod_habilitado = Convert.ToInt32(dr["cod_habilitado"]);
                operador.cod_rol = Convert.ToInt32(dr["cod_rol"]);

                operadores.Add(operador);
            }
            return operadores;
        }

        public int Borrar(Operador_en o)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_operador", o.cod_operador };
            parametros.Add(param1);

            return sql.EjecutarSP_int("Operador_Borrar", parametros);
        }
    }
}

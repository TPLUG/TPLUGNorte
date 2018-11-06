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
    public class Idioma_mpp
    {
        public int Agregar(Idioma_en i)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_idioma", i.codIdioma };
            object[] param2 = { "@detalle", i.detalle };
            object[] param3 = { "@registro_estado_cod", i.registroEstadoCod };
            object[] param4 = { "@fecha_ingreso", i.fechaIngreso };
            object[] param5 = { "@fecha_modificacion", i.fechaModificacion };
            parametros.Add(param1);
            parametros.Add(param2);
            parametros.Add(param3);
            parametros.Add(param4);
            parametros.Add(param5);
            return sql.EjecutarSP_int("Idioma_Agregar", parametros);
        }

        public int Borrar(Idioma_en i)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_idioma", i.codIdioma };
            parametros.Add(param1);
            return sql.EjecutarSP_int("Idioma_Borrar", parametros);
        }

        public Idioma_en Traer(int id)
        {
            Idioma_en idioma = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Idioma_Traer");
            if (dr.Read())
            {
                idioma = new Idioma_en();
                idioma.codIdioma = Convert.ToInt32(dr["cod_idioma"]);
                idioma.detalle = dr["detalle"].ToString();
                idioma.registroEstadoCod = Convert.ToInt32(dr["registro_estado_cod"]);
                idioma.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
                idioma.fechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"]);
                // to do: preguntar si lo siguiente seria correcto conceptualmente.
                //idioma.operadorIngreso = Operador_mpp.Traer(Convert.ToInt32(dr["operador_ingreso"]));
                //idioma.operadorModificacion = Operador_mpp.Traer(Convert.ToInt32(dr["operador_modificacion"]));
            }

            return idioma;
        }

        public List<Idioma_en> TraerTodos()
        {
            List<Idioma_en> idiomas = new List<Idioma_en>();
            Idioma_en idioma;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Idioma_TraerTodos");
            while (dr.Read())
            {
                idioma = new Idioma_en();
                idioma.codIdioma = Convert.ToInt32(dr["cod_idioma"]);
                idioma.detalle = dr["detalle"].ToString();
                idioma.registroEstadoCod = Convert.ToInt32(dr["registro_estado_cod"]);
                idioma.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
                idioma.fechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"]);
                // to do: preguntar si lo siguiente seria correcto conceptualmente.
                //idioma.operadorIngreso = Operador_mpp.Traer(Convert.ToInt32(dr["operador_ingreso"]));
                //idioma.operadorModificacion = Operador_mpp.Traer(Convert.ToInt32(dr["operador_modificacion"]));
                idiomas.Add(idioma);
            }

            return idiomas;
        }
    }
}

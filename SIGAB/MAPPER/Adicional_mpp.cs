using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER
{
    public class Adicional_mpp
    {


        public int Agregar(ENTIDADES.Adicional_en adicional)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_biblioteca	", adicional.codBiblioteca };
            object[] param2 = { "@cod_obra", adicional.codObra };
            object[] param3 = { "@cod_imagen", adicional.codImagen };
            object[] param4 = { "@principal", adicional.principal };
            object[] param5 = { "@cod_localizacion", adicional.codLocalizacion };
            object[] param6 = { "@alias", adicional.alias };
            object[] param7 = { "@nombre", adicional.nombre };
            object[] param8 = { "@cod_tipo_archivo", adicional.codTipoArchivo };
            object[] param9 = { "@descripcion", adicional.descripcion };
            object[] param10 = { "@principal_imprenta", adicional.principalImprenta };
            object[] param11 = { "@cod_habilitacion", adicional.codHabilitacion };

            parametros.Add(param1);
            parametros.Add(param2);
            parametros.Add(param3);
            parametros.Add(param4);
            parametros.Add(param5);
            parametros.Add(param6);
            parametros.Add(param7);
            parametros.Add(param8);
            parametros.Add(param9);
            parametros.Add(param10);
            parametros.Add(param11);



            return sql.EjecutarSP_int("adicional_Agregar", parametros);
        }


        public int Borrar(string codBib, int id, string codImg)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_biblioteca", codBib };
            object[] param2 = { "@cod_obra", id };
            object[] param3 = { "@cod_imagen", codImg };
            parametros.Add(param1);
            parametros.Add(param2);
            parametros.Add(param3);

            return sql.EjecutarSP_int("adicional_Borrar", parametros);
        }


        public Adicional_en Traer(int id)
        {
            ENTIDADES.Adicional_en adicional = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("adicional_Traer", "cod_obra", id);
            if (dr.Read())
            {
                adicional = new Adicional_en();

                adicional.codBiblioteca = dr["cod_biblioteca"].ToString();
                adicional.codObra = Convert.ToInt32(dr["cod_obra"]);
                adicional.codImagen = dr["cod_imagen"].ToString();
                adicional.principal = Convert.ToInt32(dr["principal"]);
                adicional.codLocalizacio = dr["cod_localizacion"].ToString();
                adicional.alias = dr["alias"].ToString();
                adicional.nombre = dr["nombre"].ToString();
                adicional.codTipoArchivo = Convert.ToInt32(dr["cod_tipo_archivo"]);
                adicional.descripcion = dr["descripcion"].ToString();
                adicional.principalImprenta = Convert.ToInt32(dr["principal_imprenta"]);
                adicional.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);



            }
            return ejemplar;
        }

        public List<Adicional_en> TraerTodos()
        {
            List<Adicional_en> adicionales = new List<Adicional_en>();
            Adicional_en adicional;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("adicional_TraerTodos");

            while (dr.Read())
            {
                adicional = new Adicional_en();

                adicional.codBiblioteca = dr["cod_biblioteca"].ToString();
                adicional.codObra = Convert.ToInt32(dr["cod_obra"]);
                adicional.codImagen = dr["cod_imagen"].ToString();
                adicional.principal = Convert.ToInt32(dr["principal"]);
                adicional.codLocalizacio = dr["cod_localizacion"].ToString();
                adicional.alias = dr["alias"].ToString();
                adicional.nombre = dr["nombre"].ToString();
                adicional.codTipoArchivo = Convert.ToInt32(dr["cod_tipo_archivo"]);
                adicional.descripcion = dr["descripcion"].ToString();
                adicional.principalImprenta = Convert.ToInt32(dr["principal_imprenta"]);
                adicional.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);

                adicionales.Add(adicional);
            }
            return adicionales;
        }



    }
}
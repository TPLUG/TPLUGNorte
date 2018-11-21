
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER
{
    public class Localizacion_mpp
{

    public int Agregar(ENTIDADES.Localizacion_en localizacion)
    {
        AccesoSQLServer sql = new AccesoSQLServer();
        List<object[]> parametros = new List<object[]>();
        object[] param1 = { "@cod_localizacion	", localizacion.codLocalizacion };
        object[] param2 = { "@nombre", localizacion.nombre };
        object[] param3 = { "@carpeta", localizacion.carpeta };
        object[] param4 = { "@direccion_postal", localizacion.direccionPostal };
        object[] param5 = { "@Direccion", localizacion.Direccion };
        object[] param6 = { "@NombreArchivo_foto", localizacion.NombreArchivoFoto };    //Mayuscula "N"ombre en BD , revisar
        object[] param7 = { "@fecha_ingreso", localizacion.fechaIngreso };
        object[] param8 = { "@fecha_modificacion", localizacion.fechaModificacion };
        object[] param9 = { "@operador_ingreso", localizacion.operadorIngreso };
        object[] param10 = { "@operador_modificacion", localizacion.operadorModificacion };
        object[] param11 = { "@cod_habilitacion", localizacion.codHabilitacion };

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



        return sql.EjecutarSP_int("localizacion_Agregar", parametros);
    }


    public int Borrar(int id)
    {
        AccesoSQLServer sql = new AccesoSQLServer();
        List<object[]> parametros = new List<object[]>();
        object[] param1 = { "@cod_localizacion", id };
        parametros.Add(param1);

        return sql.EjecutarSP_int("localizacion_Borrar", parametros);
    }


    public Localizacion_en Traer(int id)
    {
        ENTIDADES.Localizacion_en localizacion = null;
        AccesoSQLServer sql = new AccesoSQLServer();
        SqlDataReader dr = sql.EjecutarSP_DR("localizacion_Traer", "cod_localizacion", id);
        if (dr.Read())
        {
            localizacion = new Localizacion_en();

            localizacion.codLocalizacion = dr["cod_localizacion"].ToString();
            localizacion.nombre = dr["nombre"].ToString();
            localizacion.carpeta = dr["carpeta"].ToString();
            localizacion.direccionPostal = dr["direccion_postal"].ToString();
            localizacion.Direccion = dr["Direccion"].ToString();
            localizacion.NombreArchivoFoto = dr["NombreArchivo_foto"].ToString();
            localizacion.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
            localizacion.fechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"]);
            localizacion.operadorIngreso = Convert.ToInt32(dr["operador_ingreso"]);
            localizacion.operadorModificacion = Convert.ToInt32(dr["operador_modificacion"]);
            localizacion.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);


        }
        return localizacion;
    }

    public List<Localizacion_en> TraerTodos()
    {
        List<Localizacion_en> localizaciones = new List<Localizacion_en>();
        Localizacion_en localizacion;
        AccesoSQLServer sql = new AccesoSQLServer();
        SqlDataReader dr = sql.EjecutarSP_DR("localizacion_TraerTodos");

        while (dr.Read())
        {
            localizacion = new Localizacion_en();

            localizacion.codLocalizacion = dr["cod_localizacion"].ToString();
            localizacion.nombre = dr["nombre"].ToString();
            localizacion.carpeta = dr["carpeta"].ToString();
            localizacion.direccionPostal = dr["direccion_postal"].ToString();
            localizacion.Direccion = dr["Direccion"].ToString();
            localizacion.NombreArchivoFoto = dr["NombreArchivo_foto"].ToString();
            localizacion.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
            localizacion.fechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"]);
            localizacion.operadorIngreso = Convert.ToInt32(dr["operador_ingreso"]);
            localizacion.operadorModificacion = Convert.ToInt32(dr["operador_modificacion"]);
            localizacion.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);

            localizaciones.Add(localizacion);
        }
        return localizaciones;
    }

}}
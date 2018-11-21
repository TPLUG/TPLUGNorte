using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER
{

    public class ListaTipoArchivo_mpp
{

    public int Agregar(ENTIDADES.ListaTipoArchivo_en listaTipoArchivo)
    {
        AccesoSQLServer sql = new AccesoSQLServer();
        List<object[]> parametros = new List<object[]>();
        object[] param1 = { "@cod_tipo_archivo	", listaTipoArchivo.codTipoArchivo };
        object[] param2 = { "@Detalle", listaTipoArchivo.detalle };
        object[] param3 = { "@cod_habilitacion", listaTipoArchivo.codHabilitacion };

        parametros.Add(param1);
        parametros.Add(param2);
        parametros.Add(param3);

        return sql.EjecutarSP_int("lista_tipoArchivo_Agregar", parametros);
    }


    public int Borrar(int id)
    {
        AccesoSQLServer sql = new AccesoSQLServer();
        List<object[]> parametros = new List<object[]>();
        object[] param1 = { "@cod_tipo_archivo", id };
        parametros.Add(param1);

        return sql.EjecutarSP_int("lista_tipoArchivo_Borrar", parametros);
    }


    public ListaTipoArchivo_en Traer(int id)
    {
        ENTIDADES.ListaTipoArchivo_en listaTipoArchivo = null;
        AccesoSQLServer sql = new AccesoSQLServer();
        SqlDataReader dr = sql.EjecutarSP_DR("lista_tipoArchivo_Traer", "cod_tipo_archivo", id);
        if (dr.Read())
        {
            listaTipoArchivo = new ListaTipoArchivo_en();

            listaTipoArchivo.codTipoArchivo = Convert.ToInt32(dr["cod_tipo_archivo"]);
            listaTipoArchivo.detalle = dr["Detalle"].ToString();
            listaTipoArchivo.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);

        }
        return listaTipoArchivo;
    }

    public List<ListaTipoArchivo_en> TraerTodos()
    {
        List<ListaTipoArchivo_en> listaTipoArchivos = new List<ListaTipoArchivo_en>();
        ListaTipoArchivo_en listaTipoArchivo;
        AccesoSQLServer sql = new AccesoSQLServer();
        SqlDataReader dr = sql.EjecutarSP_DR("lista_tipoArchivo_TraerTodo");

        while (dr.Read())
        {
            listaTipoArchivo = new ListaTipoArchivo_en();

            listaTipoArchivo.codTipoArchivo = Convert.ToInt32(dr["cod_tipo_archivo"]);
            listaTipoArchivo.detalle = dr["Detalle"].ToString();
            listaTipoArchivo.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);

            listaTipoArchivos.Add(listaTipoArchivo);
        }
        return listaTipoArchivos;
    }


}}
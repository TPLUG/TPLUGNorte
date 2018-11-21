using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER
{

    public class ListaObra_mpp
{

    public int Agregar(ENTIDADES.ListaObra_en listaObra)
    {
        AccesoSQLServer sql = new AccesoSQLServer();
        List<object[]> parametros = new List<object[]>();
        object[] param1 = { "@cod_tipo_obra	", listaObra.codTipoObra };
        object[] param2 = { "@detalle", listaObra.detalle };
        object[] param3 = { "@es_especial", listaObra.esEspecial };
        object[] param4 = { "@dias_por_defecto", listaObra.diasPorDefecto };
        object[] param5 = { "@conferencia", listaObra.conferencia };

        parametros.Add(param1);
        parametros.Add(param2);
        parametros.Add(param3);
        parametros.Add(param4);
        parametros.Add(param5);

        return sql.EjecutarSP_int("lista_obra_Agregar", parametros);
    }


    public ListaObra_en Traer(int id)
    {
        ENTIDADES.ListaObra_en listaObra = null;
        AccesoSQLServer sql = new AccesoSQLServer();
        SqlDataReader dr = sql.EjecutarSP_DR("lista_obra_Traer", "cod_tipo_obra", id);
        if (dr.Read())
        {
            listaObra = new ListaObra_en();

            listaObra.codTipoObra = Convert.ToInt32(dr["cod_tipo_obra"]);
            listaObra.detalle = dr["detalle"].ToString();
            listaObra.esEspecial = Convert.ToInt32(dr["es_especial"]);
            listaObra.diasPorDefecto = Convert.ToInt32(dr["dias_por_defecto"]);
            listaObra.conferencia = Convert.ToInt32(dr["conferencia"]);

        }
        return listaObra;
    }

    public List<ListaObra_en> TraerTodos()
    {
        List<ListaObra_en> listaObras = new List<ListaObra_en>();
        ListaObra_en listaObra;
        AccesoSQLServer sql = new AccesoSQLServer();
        SqlDataReader dr = sql.EjecutarSP_DR("lista_obra_TraerTodo");

        while (dr.Read())
        {
            listaObra = new ListaObra_en();

            listaObra.codTipoObra = Convert.ToInt32(dr["cod_tipo_obra"]);
            listaObra.detalle = dr["detalle"].ToString();
            listaObra.esEspecial = Convert.ToInt32(dr["es_especial"]);
            listaObra.diasPorDefecto = Convert.ToInt32(dr["dias_por_defecto"]);
            listaObra.conferencia = Convert.ToInt32(dr["conferencia"]);

            listaObras.Add(listaObra);
        }
        return listaObras;
    }


}}
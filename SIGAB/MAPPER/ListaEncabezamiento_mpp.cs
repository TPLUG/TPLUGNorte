using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace MAPPER
{
    public class ListaEncabezamiento_mpp
    {
        public void Guardar(ENTIDADES.ListaEncabezamiento_en encabezadoEntidad)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_encabezamiento", encabezadoEntidad.codEncabezamiento };
            object[] param2 = { "@detalle", encabezadoEntidad.detalle };
            parametros.Add(param1);
            parametros.Add(param2);
            //return sql.EjecutarQuery_DS("Rol_Agregar", parametros);
        }
        public void Borrar(ENTIDADES.ListaEncabezamiento_en encabezadoEntidad)
        {

        }

        public DataSet Traer(ENTIDADES.ListaEncabezamiento_en encabezadoEntidad)
        {
            DataSet ds = new DataSet();
                return ds;
        }
        public DataSet TraerTodo()
        {
            DataSet ds = new DataSet();
            return ds;
        }
    }
}

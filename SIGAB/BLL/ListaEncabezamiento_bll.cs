using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class ListaEncabezamiento_bll
    {
        public int Agregar(ENTIDADES.ListaEncabezamiento_en encabezadoEntidad)
        {
            MAPPER.ListaEncabezamiento_mpp encabezadoMpp = new MAPPER.ListaEncabezamiento_mpp();
            int a = encabezadoMpp.Agregar(encabezadoEntidad);
            encabezadoMpp = null;
            return a;
        }
        public int Borrar(int id)
        {
            MAPPER.ListaEncabezamiento_mpp encabezadoMpp = new MAPPER.ListaEncabezamiento_mpp();
            int a = encabezadoMpp.Borrar(id);
            encabezadoMpp = null;
            return a;
        }

        public ENTIDADES.ListaEncabezamiento_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.ListaEncabezamiento_mpp encabezadoMpp = new MAPPER.ListaEncabezamiento_mpp();
            ENTIDADES.ListaEncabezamiento_en encabezado = encabezadoMpp.Traer(id);
            encabezadoMpp = null;
            return encabezado;
        }

        public List<ENTIDADES.ListaEncabezamiento_en> TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.ListaEncabezamiento_mpp encabezadoMpp = new MAPPER.ListaEncabezamiento_mpp();
            List< ENTIDADES.ListaEncabezamiento_en > encabezados = encabezadoMpp.TraerTodo();
            encabezadoMpp = null;
            return encabezados;
        }
    }
}

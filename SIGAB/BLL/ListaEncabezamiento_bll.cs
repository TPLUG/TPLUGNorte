using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListaEncabezamiento_bll
    {
        public void Guardar(ENTIDADES.ListaEncabezamiento_en encabezadoEntidad)
        {
            MAPPER.ListaEncabezamiento_mpp encabezadoMpp = new MAPPER.ListaEncabezamiento_mpp();
            encabezadoMpp.Guardar(encabezadoEntidad);
            encabezadoMpp = null;
        }
        public void Borrar(ENTIDADES.ListaEncabezamiento_en encabezadoEntidad)
        {
            MAPPER.ListaEncabezamiento_mpp encabezadoMpp = new MAPPER.ListaEncabezamiento_mpp();
            encabezadoMpp.Borrar(encabezadoEntidad);
            encabezadoMpp = null;
        }
    }
}

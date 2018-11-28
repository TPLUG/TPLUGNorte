using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class ObraClasificador_bll
    {
        public int Agregar(ENTIDADES.ObraClasificador_en ObraClasificador)
        {
            MAPPER.ObraClasificador_mpp ObraClasificadorMpp = new MAPPER.ObraClasificador_mpp();
            int a = ObraClasificadorMpp.Agregar(ObraClasificador);
            ObraClasificadorMpp = null;
            return a;
        }
        public int Borrar(int id)
        {
            MAPPER.ObraClasificador_mpp ObraClasificadorMpp = new MAPPER.ObraClasificador_mpp();
            int a = ObraClasificadorMpp.Borrar(id);
            ObraClasificadorMpp = null;
            return a;
        }

        public ENTIDADES.ObraClasificador_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.ObraClasificador_mpp ObraClasificadorMpp = new MAPPER.ObraClasificador_mpp();
            ENTIDADES.ObraClasificador_en ObraClasificador = ObraClasificadorMpp.Traer(id);
            ObraClasificadorMpp = null;
            return ObraClasificador;
        }

        public List<ENTIDADES.ObraClasificador_en> TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.ObraClasificador_mpp ObraClasificadorMpp = new MAPPER.ObraClasificador_mpp();
            List<ENTIDADES.ObraClasificador_en> ObraClasificadores = ObraClasificadorMpp.TraerTodo();
            ObraClasificadorMpp = null;
            return ObraClasificadores;
        }
    }
}

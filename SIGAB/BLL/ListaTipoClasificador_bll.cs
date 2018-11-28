using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class ListaTipoClasificador_bll
    {
        public int Agregar(ENTIDADES.ListaTipoClasificador_en TipoClasificador)
        {
            MAPPER.ListaTipoClasificador_mpp TipoClasificadorMpp = new MAPPER.ListaTipoClasificador_mpp();
            int a = TipoClasificadorMpp.Agregar(TipoClasificador);
            TipoClasificadorMpp = null;
            return a;
        }
        public int Borrar(int id)
        {
            MAPPER.ListaTipoClasificador_mpp TipoClasificadorMpp = new MAPPER.ListaTipoClasificador_mpp();
            int a = TipoClasificadorMpp.Borrar(id);
            TipoClasificadorMpp = null;
            return a;
        }

        public ENTIDADES.ListaTipoClasificador_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.ListaTipoClasificador_mpp TipoClasificadorMpp = new MAPPER.ListaTipoClasificador_mpp();
            ENTIDADES.ListaTipoClasificador_en TipoClasificador = TipoClasificadorMpp.Traer(id);
            TipoClasificadorMpp = null;
            return TipoClasificador;
        }

        public List<ENTIDADES.ListaTipoClasificador_en> TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.ListaTipoClasificador_mpp TipoClasificadorMpp = new MAPPER.ListaTipoClasificador_mpp();
            List<ENTIDADES.ListaTipoClasificador_en> TipoClasificadors = TipoClasificadorMpp.TraerTodo();
            TipoClasificadorMpp = null;
            return TipoClasificadors;
        }
    }
}

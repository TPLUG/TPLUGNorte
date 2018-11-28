using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Bitacora_bll
    {
        public int Agregar(ENTIDADES.Bitacora_en Bitacora)
        {
            MAPPER.Bitacora_mpp BitacoraMpp = new MAPPER.Bitacora_mpp();
            int a = BitacoraMpp.Agregar(Bitacora);
            BitacoraMpp = null;
            return a;
        }
        public int Borrar(int id)
        {
            MAPPER.Bitacora_mpp BitacoraMpp = new MAPPER.Bitacora_mpp();
            int a = BitacoraMpp.Borrar(id);
            BitacoraMpp = null;
            return a;
        }

        public ENTIDADES.Bitacora_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.Bitacora_mpp BitacoraMpp = new MAPPER.Bitacora_mpp();
            ENTIDADES.Bitacora_en Bitacora = BitacoraMpp.Traer(id);
            BitacoraMpp = null;
            return Bitacora;
        }

       /* public List<ENTIDADES.Bitacora_en> TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.Bitacora_mpp BitacoraMpp = new MAPPER.Bitacora_mpp();
            List<ENTIDADES.Bitacora_en> Bitacoras = BitacoraMpp.TraerTodo();
            BitacoraMpp = null;
            return Bitacoras;
        }*/
    }
}

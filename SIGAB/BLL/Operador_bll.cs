using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;
using ENTIDADES;

namespace BLL
{
    public class Operador_bll
    {
        private Operador_mpp mpp = new Operador_mpp();

        public int Agregar(Operador_en o)
        {
            return mpp.Agregar(o);
        }

        public Operador_en Traer(int id)
        {
            return mpp.Traer(id);
        }

        public List<Operador_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }

        public int Borrar(Operador_en o)
        {
            return mpp.Borrar(o);
        }
    }
}

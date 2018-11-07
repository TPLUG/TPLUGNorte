using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MAPPER;

namespace BLL
{
    public class Coleccion_bll
    {
        private Coleccion_mpp mpp = new Coleccion_mpp();

        public Coleccion_en Traer(int id)
        {
            return mpp.Traer(id);
        }

        public List<Coleccion_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }
    }
}

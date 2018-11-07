using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MAPPER;

namespace BLL
{
    public class Soporte_bll
    {
        private Soporte_mpp mpp = new Soporte_mpp();

        public Soporte_en Traer(int id)
        {
            return mpp.Traer(id);
        }

        public List<Soporte_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }
    }
}

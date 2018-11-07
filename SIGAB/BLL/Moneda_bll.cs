using ENTIDADES;
using MAPPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Moneda_bll
    {
        private Moneda_mpp mpp = new Moneda_mpp();

        public Moneda_en Traer(int id)
        {
            return mpp.Traer(id);
        }

        public List<Moneda_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }
    }
}

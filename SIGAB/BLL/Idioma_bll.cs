using ENTIDADES;
using MAPPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Idioma_bll
    {
        private Idioma_mpp mpp = new Idioma_mpp();

        public int Agregar(Idioma_en i)
        {
            return mpp.Agregar(i);
        }

        public int Borrar(Idioma_en i)
        {
            return mpp.Borrar(i);
        }

        public Idioma_en Traer(int id)
        {
            return mpp.Traer(id);
        }

        public List<Idioma_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }
    }
}

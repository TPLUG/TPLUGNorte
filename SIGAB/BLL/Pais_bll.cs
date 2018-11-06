using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;

namespace BLL
{
    public class Pais_bll
    {
        private Pais_mpp mpp = new Pais_mpp();

        public int Agregar(Pais_en p)
        {
            return mpp.Agregar(p);
        }

        public int Borrar(Pais_en p)
        {
            return mpp.Borrar(p);
        }

        public Pais_en Traer(int id)
        {
            return mpp.Traer(id);
        }

    }
}

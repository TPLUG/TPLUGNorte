using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MAPPER;

namespace BLL
{
    public class PatenteRol_bll
    {
        private PatenteRol_mpp mpp = new PatenteRol_mpp();

        public int Agregar (PatenteRol_en pr)
        {
            return mpp.Agregar(pr);
        }

        public PatenteRol_en Traer(int id)
        {
            return mpp.Traer(id);
        }

        public List<PatenteRol_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }

        public int Borrar(PatenteRol_en pr)
        {
            return mpp.Borrar(pr);
        }
    }
}

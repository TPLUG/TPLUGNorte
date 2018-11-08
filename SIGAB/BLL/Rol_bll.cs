using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;
using ENTIDADES;

namespace BLL
{
    public class Rol_bll
    {
        private Rol_mpp mpp = new Rol_mpp();

        public int Agregar(Rol_en r)
        {
            return mpp.Agregar(r);
        }

        public Rol_en Traer (int codigo)
        {
            return mpp.Traer(codigo);
        }

        public List<Rol_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }

        public int Borrar(Rol_en r)
        {
            return mpp.Borrar(r);
        }
    }
}

using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NivelBibliografico_mpp
    {
        private NivelBibliografico_mpp mpp = new NivelBibliografico_mpp();

        public NivelBibliografico_en Traer(int id)
        {
            return mpp.Traer(id);
        }

        public List<NivelBibliografico_en> TraerTodos()
        {
            return mpp.TraerTodos();
        }
    }
}

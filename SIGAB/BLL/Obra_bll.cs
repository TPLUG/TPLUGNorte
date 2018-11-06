using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Obra_bll
    {
        public void Guardar(ENTIDADES.Obra_en obraEntidad)
        {
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            obraMpp.Guardar(obraEntidad);
            obraMpp = null;
        }
        public void Borrar(ENTIDADES.Obra_en obraEntidad)
        {
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            obraMpp.Borrar(obraEntidad);
            obraMpp = null;
        }
    }
}

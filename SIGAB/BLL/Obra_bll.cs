using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public DataSet Traer(ENTIDADES.Obra_en obraEntidad)
        {
            DataSet ds = new DataSet();
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            ds = obraMpp.Traer(obraEntidad);
            obraMpp = null;
            return ds;
        }

        public DataSet TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            ds = obraMpp.TraerTodo();
            obraMpp = null;
            return ds;
        }
    }
}

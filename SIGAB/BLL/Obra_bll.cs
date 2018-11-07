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
        public int Guardar(ENTIDADES.Obra_en obraEntidad)
        {
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            int a = obraMpp.Agregar(obraEntidad);
            obraMpp = null;
            return a;
        }
        public int Borrar(int id)
        {
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            int a = obraMpp.Borrar(id);
            obraMpp = null;
            return a;
        }   

        public ENTIDADES.Obra_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            ENTIDADES.Obra_en obra = obraMpp.Traer(id);
            obraMpp = null;
            return obra;
        }

        public DataSet TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.Obra_mpp obraMpp = new MAPPER.Obra_mpp();
            DataSet  obrasDs = obraMpp.TraerTodo();
            obraMpp = null;
            return obrasDs;
        }
    }
}

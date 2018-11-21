using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{


    public class Adicional_bll
    {

        public int Guardar(ENTIDADES.Adicional_en ejemplar)
        {
            MAPPER.Adicional_mpp adicionalmpp = new MAPPER.Adicional_mpp();
            int a = adicionalmpp.Agregar(ejemplar);
            adicionalmpp = null;
            return a;
        }

        public int Borrar(string codBib, int id, string codImg)
        {
            MAPPER.Adicional_mpp adicionalmpp = new MAPPER.Adicional_mpp();
            int a = adicionalmpp.Borrar(codBib, id, CodImg);
            adicionalmpp = null;
            return a;
        }

        public ENTIDADES.Adicional_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.Adicional_mpp adicionalmpp = new MAPPER.Adicional_mpp();
            ds = adicionalmpp.Traer(id);
            adicionalmpp = null;
            return ds;
        }

        public DataSet TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.Adicional_mpp adicionalmpp = new MAPPER.Adicional_mpp();
            ds = adicionalmpp.TraerTodo();
            adicionalmpp = null;
            return ds;
        }

    }

}
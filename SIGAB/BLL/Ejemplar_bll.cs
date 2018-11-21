using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Ejemplar_bll
    {
        public int Guardar(ENTIDADES.Ejemplar_en ejemplar)
        {
            MAPPER.Ejemplar_mpp ejemplarmpp = new MAPPER.Ejemplar_mpp();
            int a = ejemplarmpp.Agregar(ejemplar);
            ejemplarmpp = null;
            return a;
        }

        public int Borrar(int id)
        {
            MAPPER.Ejemplar_mpp ejemplarmpp = new MAPPER.Ejemplar_mpp();
            int a = ejemplarmpp.Borrar(id);
            ejemplarmpp = null;
            return a;
        }

        public ENTIDADES.Ejemplar_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.Ejemplar_mpp ejemplarmpp = new MAPPER.Ejemplar_mpp();
            ds = ejemplarmpp.Traer(id);
            ejemplarmpp = null;
            return ds;
        }

        public DataSet TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.Ejemplar_mpp ejemplarmpp = new MAPPER.Ejemplar_mpp();
            ds = ejemplarmpp.TraerTodo();
            ejemplarmpp = null;
            return ds;
        }

    }


}
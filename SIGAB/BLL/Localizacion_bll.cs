using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class Localizacion_bll
    {

        public int Guardar(ENTIDADES.Localizacion_en localizacion)
        {
            MAPPER.Localizacion_en localizacionmpp = new MAPPER.Localizacion_en();
            int a = localizacionmpp.Agregar(localizacion);
            localizacionmpp = null;
            return a;
        }

        public int Borrar(int id)
        {
            MAPPER.Localizacion_en localizacionmpp = new MAPPER.Localizacion_en();
            int a = localizacionmpp.Borrar(id);
            localizacionmpp = null;
            return a;
        }

        public ENTIDADES.Localizacion_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.Localizacion_en localizacionmpp = new MAPPER.Localizacion_en();
            ds = localizacionmpp.Traer(id);
            localizacionmpp = null;
            return ds;
        }

        public DataSet TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.Localizacion_en localizacionmpp = new MAPPER.Localizacion_en();
            ds = localizacionmpp.TraerTodo();
            localizacionmpp = null;
            return ds;
        }


    }

}
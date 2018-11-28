using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Clasificador_bll
    {
        public int Agregar(ENTIDADES.Clasificador_en Clasificador)
        {
            MAPPER.Clasificador_mpp ClasificadorMpp = new MAPPER.Clasificador_mpp();
            int a = ClasificadorMpp.Agregar(Clasificador);
            ClasificadorMpp = null;
            return a;
        }
        public int Borrar(int id)
        {
            MAPPER.Clasificador_mpp ClasificadorMpp = new MAPPER.Clasificador_mpp();
            int a = ClasificadorMpp.Borrar(id);
            ClasificadorMpp = null;
            return a;
        }

        public ENTIDADES.Clasificador_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.Clasificador_mpp ClasificadorMpp = new MAPPER.Clasificador_mpp();
            ENTIDADES.Clasificador_en Clasificador = ClasificadorMpp.Traer(id);
            ClasificadorMpp = null;
            return Clasificador;
        }

         public List<ENTIDADES.Clasificador_en> TraerTodo()
         {
             DataSet ds = new DataSet();
             MAPPER.Clasificador_mpp ClasificadorMpp = new MAPPER.Clasificador_mpp();
             List<ENTIDADES.Clasificador_en> Clasificadores = ClasificadorMpp.TraerTodo();
             ClasificadorMpp = null;
             return Clasificadores;
         }
    }
}

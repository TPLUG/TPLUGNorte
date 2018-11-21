using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class ListaTipoArchivo_bll
    {

        public int Guardar(ENTIDADES.Adicional_en ejemplar)
        {
            MAPPER.ListaTipoArchivo_mpp listaTipoArchivompp = new MAPPER.ListaTipoArchivo_mpp();
            int a = listaTipoArchivompp.Agregar(ejemplar);
            listaTipoArchivompp = null;
            return a;
        }

        public int Borrar(int id)
        {
            MAPPER.ListaTipoArchivo_mpp listaTipoArchivompp = new MAPPER.ListaTipoArchivo_mpp();
            int a = listaTipoArchivompp.Borrar(id);
            listaTipoArchivompp = null;
            return a;
        }

        public ENTIDADES.Adicional_en Traer(int id)
        {
            DataSet ds = new DataSet();
            MAPPER.ListaTipoArchivo_mpp listaTipoArchivompp = new MAPPER.ListaTipoArchivo_mpp();
            DataSet listaTipoArchivDS = listaTipoArchivompp.Traer(id);
            listaTipoArchivompp = null;
            return listaTipoArchivDS;
        }

        public DataSet TraerTodo()
        {
            DataSet ds = new DataSet();
            MAPPER.ListaTipoArchivo_mpp listaTipoArchivompp = new MAPPER.ListaTipoArchivo_mpp();
            DataSet listaTipoArchivDS = listaTipoArchivompp.TraerTodo();
            listaTipoArchivompp = null;
            return listaTipoArchivDS;
        }



    }

}
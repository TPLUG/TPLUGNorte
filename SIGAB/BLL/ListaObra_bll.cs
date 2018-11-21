using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class ListaObra_bll
{

    public int Guardar(ENTIDADES.ListaObra_en ejemplar)
    {
        MAPPER.ListaObra_mpp listaObrampp = new MAPPER.ListaObra_mpp();
        int a = listaObrampp.Agregar(ejemplar);
        listaObrampp = null;
        return a;
    }

    /*  public int Borrar(int id)
      {
          MAPPER.ListaObra_mpp listaObrampp = new MAPPER.ListaObra_mpp();
          int a = listaObrampp.Borrar(id);
          listaObrampp = null;
          return a;
      }*/

    public ENTIDADES.ListaObra_en Traer(int id)
    {
        DataSet ds = new DataSet();
        MAPPER.ListaObra_mpp listaObrampp = new MAPPER.ListaObra_mpp();
        ds = listaObrampp.Traer(id);
        listaObrampp = null;
        return ds;
    }

    public DataSet TraerTodo()
    {
        DataSet ds = new DataSet();
        MAPPER.ListaObra_mpp listaObrampp = new MAPPER.ListaObra_mpp();
        ds = listaObrampp.TraerTodo();
        listaObrampp = null;
        return ds;
    }


}




}
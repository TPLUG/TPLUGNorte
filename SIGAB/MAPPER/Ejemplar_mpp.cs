using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPER {

    public class Ejemplar_mpp
    {
        public int Agregar(ENTIDADES.Ejemplar_en ejemplar)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_inventario	", ejemplar.codInventario };
            object[] param2 = { "@cod_localizacion", ejemplar.codLocalizacion };
            object[] param3 = { "@biblioteca_cod", ejemplar.codBiblioteca };
            object[] param4 = { "@obra_cod", ejemplar.codObra };
            object[] param5 = { "@signatura_topografica", ejemplar.signaturaTopografica };
            object[] param6 = { "@cod_prestamo", ejemplar.codPrestamo };
            object[] param7 = { "@disponible", ejemplar.disponible };
            object[] param8 = { "@cod_proveedor", ejemplar.codProveedor };
            object[] param9 = { "@precio", ejemplar.Precio };
            object[] param10 = { "@cod_modena", ejemplar.codMoneda };
            object[] param11 = { "@fecha_adquisicion", ejemplar.fechaAdquisicion };
            object[] param12 = { "@condicion_adquisicion", ejemplar.condicionAdquisicion };
            object[] param13 = { "@cod_estado", ejemplar.codEstado };
            object[] param14 = { "@cod_habilitacion", ejemplar.codHabilitacion };
            object[] param15 = { "@observaciones", ejemplar.observaciones };
            object[] param16 = { "@destino", ejemplar.destino };
            object[] param17 = { "@extra", ejemplar.extra };
            object[] param18 = { "@fecha_ingreso", ejemplar.fechaIngreso };
            object[] param19 = { "@fecha_modificado", ejemplar.fechaModificado };
            object[] param20 = { "@operador_ingreso", ejemplar.operadorIngreso };
            object[] param21 = { "@operador_modificado", ejemplar.operadorModificado };

            parametros.Add(param1);
            parametros.Add(param2);
            parametros.Add(param3);
            parametros.Add(param4);
            parametros.Add(param5);
            parametros.Add(param6);
            parametros.Add(param7);
            parametros.Add(param8);
            parametros.Add(param9);
            parametros.Add(param10);
            parametros.Add(param11);
            parametros.Add(param13);
            parametros.Add(param14);
            parametros.Add(param15);
            parametros.Add(param16);
            parametros.Add(param17);
            parametros.Add(param18);
            parametros.Add(param19);
            parametros.Add(param20);
            parametros.add(param21);


            return sql.EjecutarSP_int("ejemplar_Agregar", parametros);
        }


        public int Borrar(int id)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_inventario", id };
            parametros.Add(param1);
            return sql.EjecutarSP_int("ejemplar_Borrar", parametros);
        }


        public Ejemplar_en Traer(int id)
        {
            ENTIDADES.Ejemplar_en ejemplar = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("ejemplar_Traer","codInventario",id);
            if (dr.Read())
            {
                ejemplar = new Ejemplar_en();
               
                ejemplar.codInventario = Convert.ToInt32(dr["cod_inventario"]);
                ejemplar.codLocalizacion = dr["cod_localizacion"].ToString();
                ejemplar.codBiblioteca = Convert.ToChar(dr["biblioteca_cod"]);
                ejemplar.codObra = Convert.ToInt32(dr["obra_cod"]);
                ejemplar.signaturaTopografica = dr["signatura_topografica"].ToString();
                ejemplar.codPrestamo = Convert.ToInt32(dr["cod_prestamo"]);
                ejemplar.disponible = Convert.ToInt32(dr["disponible"]);
                ejemplar.codProveedor = Convert.ToInt32(dr["cod_proveedor"]);
                ejemplar.Precio = dr["precio"].ToString();
                ejemplar.codMoneda = Convert.ToInt32(dr["cod_modena"]);
                ejemplar.fechaAdquisicion = Convert.ToDateTime(dr["fecha_adquisicion"]);
                ejemplar.condicionAdquisicion = dr["condicion_adquisicion"].ToString();
                ejemplar.codEstado = Convert.ToInt32(dr["cod_estado"]);
                ejemplar.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);
                ejemplar.observaciones = dr["observaciones"].ToString();
                ejemplar.destino = dr["destino"].ToString();
                ejemplar.extra = dr["extra"].ToString();
                ejemplar.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
                ejemplar.fechaModificado = Convert.ToDateTime(dr["fecha_modificado"]);
                ejemplar.operadorIngreso = Convert.ToInt32(dr["operador_ingreso"]);
                ejemplar.operadorModificado = Convert.ToInt32(dr["operador_modificado"]);

              
            }
            return ejemplar;
        }

        public List<Ejemplar_en> TraerTodos()
        {
            List<Ejemplar_en> ejemplares = new List<Ejemplar_en>();
            Ejemplar_en ejemplar;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("ejemplar_TraerTodos");

            while (dr.Read())
            {
                ejemplar = new Ejemplar_en();

                ejemplar.codInventario = Convert.ToInt32(dr["cod_inventario"]);
                ejemplar.codLocalizacion = dr["cod_localizacion"].ToString();
                ejemplar.codBiblioteca = Convert.ToChar(dr["biblioteca_cod"]);
                ejemplar.codObra = Convert.ToInt32(dr["obra_cod"]);
                ejemplar.signaturaTopografica = dr["signatura_topografica"].ToString();
                ejemplar.codPrestamo = Convert.ToInt32(dr["cod_prestamo"]);
                ejemplar.disponible = Convert.ToInt32(dr["disponible"]);
                ejemplar.codProveedor = Convert.ToInt32(dr["cod_proveedor"]);
                ejemplar.Precio = dr["precio"].ToString();
                ejemplar.codMoneda = Convert.ToInt32(dr["cod_modena"]);
                ejemplar.fechaAdquisicion = Convert.ToDateTime(dr["fecha_adquisicion"]);
                ejemplar.condicionAdquisicion = dr["condicion_adquisicion"].ToString();
                ejemplar.codEstado = Convert.ToInt32(dr["cod_estado"]);
                ejemplar.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);
                ejemplar.observaciones = dr["observaciones"].ToString();
                ejemplar.destino = dr["destino"].ToString();
                ejemplar.extra = dr["extra"].ToString();
                ejemplar.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
                ejemplar.fechaModificado = Convert.ToDateTime(dr["fecha_modificado"]);
                ejemplar.operadorIngreso = Convert.ToInt32(dr["operador_ingreso"]);
                ejemplar.operadorModificado = Convert.ToInt32(dr["operador_modificado"]);

                ejemplares.Add(ejemplar);
            }
            return ejemplares;
        }


    }

}
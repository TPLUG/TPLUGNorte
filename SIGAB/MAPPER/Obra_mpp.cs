using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using ENTIDADES;

namespace MAPPER
{
    public class Obra_mpp
    {
        public int Agregar(ENTIDADES.Obra_en obra)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_obra", obra.codObra };
            object[] param2 = { "@cod_nivel_bibliografico", obra.codNivelBibliografico };
            object[] param3 = { "@cod_coleccion", obra.codColeccion };
            object[] param4 = { "@cod_tipo_obra", obra.codTipoObra };
            object[] param5 = { "@cod_Soporte", obra.codSoporte };
            object[] param6 = { "@cod_encabezamiento", obra.codEncabezado};
            object[] param7 = { "@titulo_corto", obra.tituloCorto };
            object[] param8 = { "@titulo", obra.titulo };
            object[] param9 = { "@titulo_uniforme", obra.tituloUniforme };
            object[] param10 = { "@edicion", obra.edicion };
            object[] param11 = { "@cod_pais", obra.codPais };
            object[] param12 = { "@frecuencia", obra.frecuencia };
            object[] param13 = { "@lugar", obra.lugar};
            object[] param14 = { "@fecha_edicion_inicio", obra.fechaEdicionInicio };
            object[] param15 = { "@fecha_edicion_final", obra.fechaEdicionFinal };
            object[] param16 = { "@preliminares", obra.preliminares };
            object[] param17 = { "@extencion", obra.extencion };
            object[] param18 = { "@cod_extencion", obra.codExtencion };
            object[] param19 = { "@extencion_secundaria", obra.extencionSecundaria };
            object[] param20 = { "@extencion_secundaria_unidad", obra.extencionSecundariaUnidad };
            object[] param21 = { "@ilustracion", obra.ilustracion };
            object[] param22 = { "@alto", obra.alto };
            object[] param23 = { "@ancho", obra.ancho };
            object[] param24 = { "@profundidad", obra.profundidad };
            object[] param25 = { "@unidad", obra.unidad };
            object[] param26 = { "@complemento", obra.complemento };
            object[] param27 = { "@obra_padre", obra.obraPadre.codObra };
            object[] param28 = { "@orden_coleccion", obra.ordenColeccion };
            object[] param29 = { "@serie_inicio", obra.serieInicio };
            object[] param30 = { "@serie_fin", obra.serieFin };
            object[] param31 = { "@serie_ano_real", obra.serieAnoReal };
            object[] param32 = { "@serie_ano_interno", obra.serieAnoInterno };
            object[] param33 = { "@serie_volumen", obra.serieVolumen };
            object[] param34 = { "@area_specifica", obra.areaEspecifica };
            object[] param35 = { "@epoca_inicio", obra.epocaInicio };
            object[] param36 = { "@epoca_fin", obra.epocaFin };
            object[] param37 = { "@notas", obra.notas };
            object[] param38 = { "@resumen", obra.resumen };
            object[] param39 = { "@resumen_idioma", obra.resumenIdioma };
            object[] param40 = { "@titulo_original", obra.tituloOriginal };
            object[] param41 = { "@titulo_original_idioma", obra.tituloOriginalIdioma };
            object[] param42 = { "@isbn", obra.isbn };
            object[] param43 = { "@coden", obra.coden };
            object[] param44 = { "@otros", obra.otros };
            object[] param45 = { "@observaciones", obra.observaciones };
            object[] param46 = { "@cod_estado", obra.codEstado };
            object[] param47 = { "@cod_habilitacion", obra.codHabilitacion };
            object[] param48 = { "@destino", obra.destino };
            object[] param49 = { "@extra", obra.extra };
            object[] param50 = { "@cita_html", obra.citaHTML };           
            object[] param51 = { "@cantidad_ejemplar", obra.cantidadEjemplar };
            object[] param52 = { "@cantidad_imagen", obra.cantidadImagen };
            object[] param53 = { "@tiene_texto_completo", obra.tieneTextoCompleto };
            object[] param54 = { "@registro_estado_cod", obra.registroEstadoCod };
            object[] param55 = { "@fecha_ingreso", obra.fechaIngreso };
            object[] param56 = { "@fecha_modificacion", obra.fechaModificacion };
            object[] param57 = { "@cod_operador_ingreso", obra.codOperadorIngreso };
            object[] param58 = { "@cod_operador_modif", obra.codOperadorModif };
            object[] param59 = { "@extra", obra.extra };

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
            parametros.Add(param21);
            parametros.Add(param22);
            parametros.Add(param23);
            parametros.Add(param24);
            parametros.Add(param25);
            parametros.Add(param26);
            parametros.Add(param27);
            parametros.Add(param28);
            parametros.Add(param29);
            parametros.Add(param30);
            parametros.Add(param31);
            parametros.Add(param32);
            parametros.Add(param33);
            parametros.Add(param34);
            parametros.Add(param35);
            parametros.Add(param36);
            parametros.Add(param37);
            parametros.Add(param38);
            parametros.Add(param39);
            parametros.Add(param40);
            parametros.Add(param41);
            parametros.Add(param42);
            parametros.Add(param43);
            parametros.Add(param44);
            parametros.Add(param45);
            parametros.Add(param46);
            parametros.Add(param47);
            parametros.Add(param48);
            parametros.Add(param49);
            parametros.Add(param50);
            parametros.Add(param51);
            parametros.Add(param52);
            parametros.Add(param53);
            parametros.Add(param54);
            parametros.Add(param55);
            parametros.Add(param56);
            parametros.Add(param57);
            parametros.Add(param58);
            parametros.Add(param59);

            return sql.EjecutarSP_int("Obra_Agregar", parametros);
        }
        public int Borrar(int id)
        {
            AccesoSQLServer sql = new AccesoSQLServer();
            List<object[]> parametros = new List<object[]>();
            object[] param1 = { "@cod_Obra", id };
            parametros.Add(param1);
            return sql.EjecutarSP_int("Obra_Borrar", parametros);
        }

        public Obra_en Traer(int id)
        {
            Obra_en obra = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Obra_Traer"/*,id*/);
            if (dr.Read())
            {
                obra = new Obra_en();
                

                obra.codObra = Convert.ToInt32(dr["cod_obra"]);
                obra.codNivelBibliografico = Convert.ToInt32(dr["cod_nivel_bibliografico"]);
                obra.codColeccion = Convert.ToInt32(dr["cod_coleccion"]);
                obra.codTipoObra = Convert.ToInt32(dr["cod_tipo_obra"]);
                obra.codSoporte  = Convert.ToInt32(dr["@cod_Soporte"]);
                obra.codEncabezado = Convert.ToInt32(dr["cod_encabezamiento"]);
                obra.tituloCorto = dr["@titulo_corto"].ToString();
                obra.titulo = dr["titulo"].ToString();
                obra.tituloUniforme =dr["titulo_uniforme"].ToString();
                obra.edicion = dr["edicion"].ToString();
                obra.codPais= Convert.ToInt32(dr["cod_pais"]);
                obra.frecuencia = dr["frecuencia"].ToString();
                obra.lugar = dr["lugar"].ToString();
                obra.fechaEdicionInicio = Convert.ToDateTime(dr["fecha_edicion_inicio"]);
                obra.fechaEdicionFinal = Convert.ToDateTime( dr["fecha_edicion_final"]);
                obra.preliminares = dr["preliminares"].ToString();
                obra.extencion = Convert.ToInt32(dr["extencion"]);
                obra.codExtencion = Convert.ToInt32(dr["cod_extencion"]);
                obra.extencionSecundaria = Convert.ToInt32(dr["extencion_secundaria"]);
                obra.extencionSecundariaUnidad = Convert.ToInt32(dr["extencion_secundaria_unidad"]);
                obra.ilustracion = dr["ilustracion"].ToString();
                obra.alto = Convert.ToInt32(dr["alto"]);
                obra.ancho = Convert.ToInt32(dr["ancho"]);
                obra.profundidad = Convert.ToInt32(dr["profundidad"]);
                obra.unidad = Convert.ToInt32(dr["unidad"]);
                obra.complemento = dr["complemento"].ToString();
                obra.obraPadre.codObra = Convert.ToInt32(dr["obra_padre"]);
                obra.ordenColeccion = Convert.ToInt32(dr["orden_coleccion"]);
                obra.serieInicio = Convert.ToInt32(dr["serie_inicio"]);
                obra.serieFin = Convert.ToInt32(dr["serie_fin"]);
                obra.serieAnoReal = Convert.ToInt32(dr["serie_ano_real"]);
                obra.serieAnoInterno = Convert.ToInt32(dr["serie_ano_interno"]);
                obra.serieVolumen = dr["serie_volumen"].ToString();
                obra.areaEspecifica = dr["area_specifica"].ToString();
                obra.epocaInicio = Convert.ToInt32(dr["epoca_inicio"]);
                obra.epocaFin = Convert.ToInt32(dr["epoca_fin"]);
                obra.notas = dr["notas"].ToString();
                obra.resumen = dr["resumen"].ToString();
                obra.resumenIdioma = dr["resumen_idioma"].ToString();
                obra.tituloOriginal = dr["titulo_original"].ToString();
                obra.tituloOriginalIdioma = dr["titulo_original_idioma"].ToString();
                obra.isbn = dr["isbn"].ToString();
                obra.coden = dr["coden"].ToString();
                obra.otros = dr["otros"].ToString();
                obra.observaciones = dr["observaciones"].ToString();
                obra.codEstado = Convert.ToInt32(dr["cod_estado"]);
                obra.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);
                obra.destino = dr["destino"].ToString();
                obra.extra = dr["extra"].ToString();
                obra.citaHTML = dr["cita_html"].ToString();
                obra.cantidadEjemplar = Convert.ToInt32(dr["cantidad_ejemplar"]);
                obra.cantidadImagen = Convert.ToInt32(dr["cantidad_imagen"]);
                obra.tieneTextoCompleto = Convert.ToInt32(dr["tiene_texto_completo"]);
                obra.registroEstadoCod= Convert.ToInt32(dr["registro_estado_cod"]);
                obra.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
                obra.fechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"]);
                obra.codOperadorIngreso = Convert.ToInt32(dr["cod_operador_ingreso"]);
                obra.codOperadorModif = Convert.ToInt32(dr["cod_operador_modif"]);
                obra.extra = dr["extra"].ToString();
            }
            return obra;
        }
        public List<Obra_en> TraerTodo()
        {
            List<Obra_en> obras = new List<Obra_en>();
            Obra_en obra = null;
            AccesoSQLServer sql = new AccesoSQLServer();
            SqlDataReader dr = sql.EjecutarSP_DR("Obra_TraerTodo");
            if (dr.Read())
            {
                obra = new Obra_en();


                obra.codObra = Convert.ToInt32(dr["cod_obra"]);
                obra.codNivelBibliografico = Convert.ToInt32(dr["cod_nivel_bibliografico"]);
                obra.codColeccion = Convert.ToInt32(dr["cod_coleccion"]);
                obra.codTipoObra = Convert.ToInt32(dr["cod_tipo_obra"]);
                obra.codSoporte = Convert.ToInt32(dr["@cod_Soporte"]);
                obra.codEncabezado = Convert.ToInt32(dr["cod_encabezamiento"]);
                obra.tituloCorto = dr["@titulo_corto"].ToString();
                obra.titulo = dr["titulo"].ToString();
                obra.tituloUniforme = dr["titulo_uniforme"].ToString();
                obra.edicion = dr["edicion"].ToString();
                obra.codPais = Convert.ToInt32(dr["cod_pais"]);
                obra.frecuencia = dr["frecuencia"].ToString();
                obra.lugar = dr["lugar"].ToString();
                obra.fechaEdicionInicio = Convert.ToDateTime(dr["fecha_edicion_inicio"]);
                obra.fechaEdicionFinal = Convert.ToDateTime(dr["fecha_edicion_final"]);
                obra.preliminares = dr["preliminares"].ToString();
                obra.extencion = Convert.ToInt32(dr["extencion"]);
                obra.codExtencion = Convert.ToInt32(dr["cod_extencion"]);
                obra.extencionSecundaria = Convert.ToInt32(dr["extencion_secundaria"]);
                obra.extencionSecundariaUnidad = Convert.ToInt32(dr["extencion_secundaria_unidad"]);
                obra.ilustracion = dr["ilustracion"].ToString();
                obra.alto = Convert.ToInt32(dr["alto"]);
                obra.ancho = Convert.ToInt32(dr["ancho"]);
                obra.profundidad = Convert.ToInt32(dr["profundidad"]);
                obra.unidad = Convert.ToInt32(dr["unidad"]);
                obra.complemento = dr["complemento"].ToString();
                obra.obraPadre.codObra = Convert.ToInt32(dr["obra_padre"]);
                obra.ordenColeccion = Convert.ToInt32(dr["orden_coleccion"]);
                obra.serieInicio = Convert.ToInt32(dr["serie_inicio"]);
                obra.serieFin = Convert.ToInt32(dr["serie_fin"]);
                obra.serieAnoReal = Convert.ToInt32(dr["serie_ano_real"]);
                obra.serieAnoInterno = Convert.ToInt32(dr["serie_ano_interno"]);
                obra.serieVolumen = dr["serie_volumen"].ToString();
                obra.areaEspecifica = dr["area_specifica"].ToString();
                obra.epocaInicio = Convert.ToInt32(dr["epoca_inicio"]);
                obra.epocaFin = Convert.ToInt32(dr["epoca_fin"]);
                obra.notas = dr["notas"].ToString();
                obra.resumen = dr["resumen"].ToString();
                obra.resumenIdioma = dr["resumen_idioma"].ToString();
                obra.tituloOriginal = dr["titulo_original"].ToString();
                obra.tituloOriginalIdioma = dr["titulo_original_idioma"].ToString();
                obra.isbn = dr["isbn"].ToString();
                obra.coden = dr["coden"].ToString();
                obra.otros = dr["otros"].ToString();
                obra.observaciones = dr["observaciones"].ToString();
                obra.codEstado = Convert.ToInt32(dr["cod_estado"]);
                obra.codHabilitacion = Convert.ToInt32(dr["cod_habilitacion"]);
                obra.destino = dr["destino"].ToString();
                obra.extra = dr["extra"].ToString();
                obra.citaHTML = dr["cita_html"].ToString();
                obra.cantidadEjemplar = Convert.ToInt32(dr["cantidad_ejemplar"]);
                obra.cantidadImagen = Convert.ToInt32(dr["cantidad_imagen"]);
                obra.tieneTextoCompleto = Convert.ToInt32(dr["tiene_texto_completo"]);
                obra.registroEstadoCod = Convert.ToInt32(dr["registro_estado_cod"]);
                obra.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
                obra.fechaModificacion = Convert.ToDateTime(dr["fecha_modificacion"]);
                obra.codOperadorIngreso = Convert.ToInt32(dr["cod_operador_ingreso"]);
                obra.codOperadorModif = Convert.ToInt32(dr["cod_operador_modif"]);
                obra.extra = dr["extra"].ToString();
                obras.Add(obra);
            }
            return obras;
        }
    }
}

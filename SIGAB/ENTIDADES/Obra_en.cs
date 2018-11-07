using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Obra_en
    {
        public int codObra { get; set; } //ver si esto es asi o se agrega automatico
        public int codNivelBibliografico { get; set; }  //Ver que hacen con Lista_nivel_bibliografico
        public int codColeccion { get; set; }   //Ver que hacen con Lista_tipocoleccion
        public int codTipoObra { get; set; }    //Ver que hacen con Lista_obra
        public int codSoporte { get; set; } // Ver que hacen con Lista_soporte
        public int codEncabezado { get; set; } // desconosco si dejarlo asi o solamente meterlo como un int y mandarle codEncabezado como muestra en la tabla
        public string tituloCorto { get; set; }
        public string titulo { get; set; }
        public string tituloUniforme { get; set; }
        public string edicion { get; set; }
        public int codPais { get; set; }
        public string frecuencia { get; set; }
        public string lugar { get; set; }
        public DateTime fechaEdicionInicio { get; set; }
        public DateTime fechaEdicionFinal { get; set; }
        public string preliminares { get; set; }
        public int extencion { get; set; }//Esperar a ver que hacen con Lista_Extencion
        public int codExtencion { get; set; }////Esperar a ver que hacen con Lista_Extencion
        public int extencionSecundaria { get; set; } //consultar
        public int extencionSecundariaUnidad { get; set; } //consultar
        public string ilustracion { get; set; }
        public int alto { get; set; }
        public int ancho { get; set; }
        public int profundidad { get; set; }
        public int unidad { get; set; }
        public string complemento { get; set; }
        public Obra_en obraPadre { get; set; }
        public int ordenColeccion { get; set; }
        public int serieInicio { get; set; }
        public int serieFin { get; set; }
        public int serieAnoReal { get; set; }
        public int serieAnoInterno { get; set; }
        public string serieVolumen { get; set; }
        public DateTime serieFecha { get; set; }
        public string areaEspecifica { get; set; }
        public int epocaInicio { get; set; }
        public int epocaFin { get; set; }
        public string notas { get; set; }
        public string resumen { get; set; }
        public string resumenIdioma { get; set; }
        public string tituloOriginal { get; set; }
        public string tituloOriginalIdioma { get; set; }
        public string isbn { get; set; }
        public string coden { get; set; }
        public string otros { get; set; }
        public string observaciones { get; set; }
        public int codEstado { get; set; } // ver que hacen con Lista_Estado
        public int codHabilitacion { get; set; } //ver que hacen con Lista_Habilitacion
        public string destino { get; set; }
        public string extra { get; set; }
        public string citaHTML { get; set; }
        public int cantidadEjemplar { get; set; }
        public int cantidadImagen { get; set; } 
        public int tieneTextoCompleto { get; set; }
        public int registroEstadoCod { get; set; }  //consultar
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int codOperadorIngreso { get; set; } // ver que hacen con Operador
        public int codOperadorModif { get; set; }// ver que hacen con Operador


    }
}

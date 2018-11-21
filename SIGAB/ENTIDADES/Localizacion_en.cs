using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Localizacion_en
    {

        public string codLocalizacion { get; set; }
        public string nombre { get; set; }
        public string carpeta { get; set; }
        public string direccionPostal { get; set; }
        public string Direccion { get; set; }
        public string NombreArchivoFoto { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int operadorIngreso { get; set; }
        public int operadorModificacion { get; set; }
        public int codHabilitacion { get; set; }

    }
}
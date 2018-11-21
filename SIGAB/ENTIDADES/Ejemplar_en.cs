using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Ejemplar_en
    {

        public int codInventario { get; set; }
        public string codLocalizacion { get; set; }
        public char codBiblioteca { get; set; }
        public int codObra { get; set; }
        public string signaturaTopografica { get; set; }
        public int codPrestamo { get; set; }
        public int disponible { get; set; }
        public int codProveedor { get; set; }
        public string Precio { get; set; }
        public int codMoneda { get; set; }
        public DateTime fechaAdquisicion { get; set; }
        public string condicionAdquisicion { get; set; }
        public int codEstado { get; set; }
        public int codHabilitacion { get; set; }
        public string observaciones { get; set; }
        public string destino { get; set; }
        public string extra { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaModificado { get; set; }
        public int operadorIngreso { get; set; }
        public int operadorModificado { get; set; }


    }
     


}

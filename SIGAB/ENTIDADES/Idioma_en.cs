using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Idioma_en
    {
        public int codIdioma { get; set; }
        public string detalle { get; set; }
        public int registroEstadoCod { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaModificacion { get; set; }
        // to do: descomentar lo siguiente cuando esten creadas las clases
        //public Operador operadorIngreso { get; set; }
        //public Operador operadorModificacion { get; set; }
    }
}

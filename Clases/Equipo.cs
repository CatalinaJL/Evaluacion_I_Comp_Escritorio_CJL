using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_I_Comp_Escritorio_CJL.Clases
{
    public class Equipo { 
    
        // propiedades 

        public string NombreEquipo { get; set; } = null!;
        public int CantidadJugadores { get; set; }
        public String NombreDT { get; set; } = null!;
        public String TipoEquipo { get; set; }= null!;
        public String CapitanEquipo { get; set; } = null!;
        public bool TieneSub21 { get; set; }

        // constructor sin parametros
        public Equipo() { }

        // constructor con parametros 

        public Equipo(string nombreEquipo, int cantidadJugadores, string nombreDT, 
                       string tipoEquipo, string capitanEquipo,bool tieneSub21 ) 
        { 
              NombreEquipo = nombreEquipo;
              CantidadJugadores = cantidadJugadores;
              NombreDT = nombreDT;
              TipoEquipo = tipoEquipo;
              CapitanEquipo = capitanEquipo;
              TieneSub21 = tieneSub21;
        }
    
    }
}

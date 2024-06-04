using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _28_05_Excepciones
{
    public class NroImparExcepcion : Exception
    {
        //Sobreescribo de la clase Exception
        public override string Message
        {
            get { return "El divisor NO puede ser un nro IMPAR"; }
        }
        public override string? HelpLink
        {
            get { return "Mas informacion en:  https://frra.cvg.utn.edu.ar/"; }
        }
    }
}
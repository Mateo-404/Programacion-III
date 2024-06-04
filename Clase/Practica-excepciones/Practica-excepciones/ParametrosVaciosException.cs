using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_excepciones
{
    internal class ParametrosVaciosException: Exception
    {
        public ParametrosVaciosException(string message) : base(message)
        {
        }
    }
}

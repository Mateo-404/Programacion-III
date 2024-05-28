using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1
{
    public abstract class Persona : IAccesible
    {
        public abstract void Acceder();
        public abstract void Identificarse();
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _28_05_Excepciones
{
    public class AreaRectanguloException : Exception
    {
        public AreaRectanguloException(string Message) : base(Message){
        }
    }
}
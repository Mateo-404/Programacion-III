using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public static class Matematicas
    {
        private static double pi = Math.PI;

        public static double Pi { get => pi;}

        public static double sumar(int num1, int num2){
            return num1+num2;
        }
    }
}
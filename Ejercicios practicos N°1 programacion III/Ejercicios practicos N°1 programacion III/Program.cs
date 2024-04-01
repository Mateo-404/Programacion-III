using System.Collections;

namespace Ejercicios_practicos_N_1_programacion_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<-- Ejercicio 1 -->
            /*
            Console.WriteLine("¡Hola! Ingresa tu nombre...");
            String nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}!");
            */

            //<-- Ejercicio 2 -->
            /*
            int numero, resultado = 1;

            Console.WriteLine("Ingrese el número entero para obtener el factorial: ");
            numero = uint.Parse(Console.ReadLine());

            //Factorial
            for (int i = 1; i < numero; i++){
                resultado *= i;
            }

            Console.WriteLine($"El factorial de {numero} es: {resultado*numero}");
            
            */

            //<-- Ejercicio 3 -->
            /*
            Console.WriteLine("Ingrese un numero para verificar si es par: ");
            double numero = double.Parse(Console.ReadLine());

            // Verificación de la paridad del numero
            if ((numero % 2) == 0)
            {
                Console.WriteLine($"El numero {numero} es par");
            }else{
                Console.WriteLine($"El numero {numero} es impar");
            }
            */

            // <-- Ejercicio 4 -->
            /*
            long resultado = 0;

            Console.WriteLine("Ingrese el numero: ");
            long numero = long.Parse(Console.ReadLine());

            // La maxima cantidad de digitos que puede tener un numero es de 19
            for (byte i = 0; i < 19; i++) {
                if (numero != 0)
                {
                    // Se suma el ultimo digito
                    resultado += (numero % 10);
                    // Se elimina el ultimo digito
                    numero /= 10;
                }else{
                    break;
                }
            }
            Console.WriteLine($"El resultado de la suma de los digitos de {numero} es {resultado}");
            */

            //<-- Ejercicio 5 -->
        }
    }
}

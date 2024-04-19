using System.Collections;
using System.ComponentModel;

namespace Ejercicios_practicos_N_1_programacion_III
{
    internal class Program
    {
        public static int[] metodoBurbuja(int[] lista){
            //<-- Ejercicio 6 -->
            int aux;
            //! Falta el while
            for (int i = 0; i < (lista.Length -1); i++){
                if (lista[i] > lista[i+1]){
                    aux = lista[i];
                    lista[i] = lista[i+1];
                    lista[i+1] = (int)aux;
                }
            }
            return lista;
        }
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
            /*
            //? PREGUNTAR AL PROFE SI TRABAJAMOS CON EL USUARIO IDEAL
            double suma = 0 ;
            uint contador = 0;
            String input = "0";

            do{
                suma += double.TryParse(input, out double num) ? num : 0;
                contador ++;
                Console.WriteLine("Ingrese el numero o \"C\" para terminar: ");
                input = Console.ReadLine();
            }while(!(input.ToLower().Equals("c")));

            Console.WriteLine($"El promedio es: {suma/(contador-1)}");
            */

            // <-- Ejercicio 6 -->
            int[] lista = new int[0];
            uint contador = 0;
            string input;
            do{
                Console.WriteLine("Ingrese el elemento n°" + (contador+1) + " o pulse cualquier tecla para terminar: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int num)){
                    lista = new int[contador+1];
                    lista[contador] = num;
                    contador ++;
                }else{
                    break;
                }    
            }while(true);

            Console.Write("La lista ordenada es: ");
            foreach(int num in metodoBurbuja(lista)){
                Console.Write($"{num} ");
            }



        }
    }
}

namespace _28_05_Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nro, divisor;
            bool flag = false;
            /*
            do
            {
                // <-- Ejercicio 1 -->
                try
                {
                    Console.WriteLine("Ingrese un nro: \n");
                    nro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el divisor: \n");
                    divisor = int.Parse(Console.ReadLine());
                    if (divisor % 2 != 0)
                    {
                        //Podes asignarle a una variable la excepcion
                        //NroImparExcepcion exep = new NroImparExcepcion();
                        //! En este caso no rompes la pila de excepciones
                        flag = true;
                        throw new NroImparExcepcion();
                        //! Si tirás la excepcion de "throw exep" D1 rompes la pila de excepciones
                    }
                    Console.WriteLine($"El resutado es: {(nro / divisor)}");
                    flag = false;
                }
                catch (NroImparExcepcion e)
                {
                    //Podés mostrar las diferentes propiedades de la excepción
                    Console.WriteLine($"Mensaje: {e.Message}");
                    Console.WriteLine($"Link de ayuda {e.HelpLink}");
                }
            } while (flag);

            
        }
        */
            //?<-- Ejercicio practico power: "2 Excepciones"
            float longitud, ancho;
            try
            {
                Console.WriteLine("Ingrese la longitud del rectangulo:");
                longitud = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el ancho del rectangulo: ");
                ancho = float.Parse(Console.ReadLine());

                if (longitud < 0)
                {
                    throw new AreaRectanguloException("La longitud es negativa");
                }

                if (ancho < 0)
                {
                    throw new AreaRectanguloException("El ancho es negativo");
                }

                Console.WriteLine($"El area del rectángulo es de: {longitud * ancho}");
            }
            catch (AreaRectanguloException e)
            {
                
                Console.WriteLine($"¡ERROR! {e.Message}");;
            }
            catch (Exception e){
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}

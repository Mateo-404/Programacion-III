using System;
using System.Text;

namespace _04_06_Archivos_Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //  <-- Ejemplo 1 del PowerPoint -->
            Console.WriteLine("¿Es Windows?: {0}", OperatingSystem.IsWindows());
            Console.WriteLine("¿Es Linux?: {0}", OperatingSystem.IsLinux());
            Console.WriteLine("¿Es MacOS?: {0}", OperatingSystem.IsMacOS());
            Console.WriteLine("¿Es IOS?: {0}", OperatingSystem.IsIOS());
            Console.WriteLine("¿Es Android?: {0}", OperatingSystem.IsAndroid());

            //  Ejemplo 2
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion);
            Console.WriteLine("OSVersion.Platform: {0}", Environment.OSVersion.Platform);
            Console.WriteLine("OSVersion.Version: {0}", Environment.OSVersion.Version);

            //  Ejemplo 3
            Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, -26} | {4, -26} |", "Nombre", "Tipo", "Formato", "Tamaño", "Espacio libre");

            foreach (DriveInfo unidad in DriveInfo.GetDrives())
            {
                if (unidad.IsReady)
                {
                    Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, 20:N0} bytes | {4, 20:N0} bytes|",
                    unidad.Name, unidad.DriveType, unidad.DriveFormat, unidad.TotalSize,
                    unidad.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("{0, -10} | {1, -10}", unidad.Name, unidad.DriveType);
                }

            }
            // Archivos 1
            StringBuilder _variableString = new StringBuilder();
            _variableString.AppendLine("¡Hola! Soy un archivo txt");
            _variableString.AppendLine("Otra Linea");
            File.WriteAllText("./Archivo.txt", _variableString.ToString());
            */
            
            //Archivos 2
            string[] lista = {"Linea 1", "Linea 2"};
            File.WriteAllLines("Archivos.txt", lista);
            //No trabajas con la clase File, trabajas con el StreamWriter y hay que instanciarlo 
            //StreamWriter streamWriter= new StreamWriter("");
            //sFile.streamWriter("Archivo.txt", lista);
            StreamWriter streamWriter = null;
            try
            {
                List<string> lineas = new List<string>();
                streamWriter = new StreamWriter("Archivo.txt", true); //El true se agrega para que Agregue al Final del Archivo (Sino crea uno de 0), que no Sobreescriba nd
                foreach(string str in lista){
                    //Escribiendo lineas
                    if (str.ToLower().Contains("rafaela"))
                    {
                        streamWriter.WriteLine(str);
                    }
                }
                //  Se Cierra Archivo
                streamWriter.Close();  
                //  Liberar el Recurso  
                streamWriter.Dispose();
            }
            finally
            {
                //  Si Contiene algo el archivo, para descartar errores de Permisos, Accesos, No Tener Acceso a Archivos 
                if (streamWriter != null)
                {
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
        }
    }
}

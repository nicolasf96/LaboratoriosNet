using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Por favor ingrese un texto: ");
            Console.WriteLine();
            string inputText = System.Console.ReadLine();
            if (String.IsNullOrEmpty(inputText))
            {
                Console.WriteLine("No se ha ingresado ningun texto ");
            }


            else
            {
                Console.WriteLine("OPCIONES \n 1 - Mostrar en mayúsculas \n 2 - Mostrar en minúsculas \n 3 - Cantidad de caracteres ");
                ConsoleKeyInfo opcion = Console.ReadKey();

                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputText.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {

                    Console.WriteLine(inputText.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {

                    Console.WriteLine(inputText.Length);
                }
                else
                {
                    Console.WriteLine("No selecciono una opcion valida");
                }

            }
        }

    }
}


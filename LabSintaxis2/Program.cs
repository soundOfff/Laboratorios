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
            string inputTxt = Console.ReadLine();
            Console.WriteLine(inputTxt);
            if (inputTxt == "")
            {
                Console.WriteLine("La cadena esta vacia!");
            }
            Console.WriteLine("1- Mostrar txt en Mayuscula 2- Mostrar en Minuscula 3- Mostrar cantidad de caracteres");
            ConsoleKeyInfo opcion = Console.ReadKey();
            
            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n{0}", inputTxt.ToUpper());
                    break;
                case ConsoleKey.D2: 
                    Console.WriteLine("\n{0}", inputTxt.ToLower());
                   break;
                case ConsoleKey.D3:
                    Console.WriteLine("\n{0}", inputTxt.Length);
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}

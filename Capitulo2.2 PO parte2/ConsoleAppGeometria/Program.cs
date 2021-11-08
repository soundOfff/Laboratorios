using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace ConsoleAppGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo();

            circ1.setRadio(10);
            Console.WriteLine("Perimetro: {0}", circ1.CalcularPerimetro());
            Console.WriteLine("Superficie: {0}", circ1.CalcularSuperfie());

        }
    }
}

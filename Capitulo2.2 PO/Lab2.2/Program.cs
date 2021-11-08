using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            A NuevaInstancia = new A("NOMBRE_EJEMPLO");
            A nuevaInstancia2 = new A();
            B instanciaB = new B();

            NuevaInstancia.MostrarNombre();
            NuevaInstancia.M1();
            NuevaInstancia.M2();
            NuevaInstancia.M3();
            nuevaInstancia2.MostrarNombre();
            instanciaB.MostrarNombre();
            instanciaB.M4();
            Console.ReadKey();
        }
    }
}

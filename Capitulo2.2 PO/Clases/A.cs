using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        private string nombreInstancia;

        public A()
        {
            nombreInstancia = "Nombre Inexistente";
        }
        public A(string nombre)
        {
            nombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(nombreInstancia);
        }
        public void  M1()
        {
            Console.WriteLine("M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("M2 fue invocado");
        }
        public void M3()
        {
            Console.WriteLine("M3 fue invocado");
        }

    }
}

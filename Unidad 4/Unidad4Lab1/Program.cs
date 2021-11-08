using System;
using System.IO;


namespace Unidad4Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menos eficiente para texto
            /*FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            while (lector.Length > lector.Position)
            {
                Console.Write((char)lector.ReadByte());
            }
            lector.Close();*/
            // Mas eficiente
            string seguir = "s";
            int op;
            while (seguir == "s")
            {
                Console.WriteLine("1- Escribir 2- Leer");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    escribir();
                }
                else if (op == 2)
                {
                    leer();
                }

                Console.WriteLine("¿Desea segir? s/n");
                seguir = Console.ReadLine();
            }

            Console.ReadKey();
        }

        private static void leer()
        {
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\teMail\ttelefono");
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(";");
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            } while (linea != null);
            lector.Close();
        }
        private static void escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto");
            string rta = "s";
            while (rta == "s")
            {
                Console.WriteLine("Ingrese nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese apellido");
                string apellido = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese email");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese telefono");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);
                Console.WriteLine("¿Desea agregar otro contrato?");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }
    }
}

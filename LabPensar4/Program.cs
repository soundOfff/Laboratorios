using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPensar4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine("El numero <{0}> sumado a <{1}> resulta: {2}", a, b, a + b);
            //1

            Console.WriteLine();

            //2
            /* 
            int anio = Convert.ToInt32(Console.ReadLine());
            if (anio % 4 == 0 )
            {
                Console.WriteLine("Biciesto");
            }
            else if (anio % 100 == 0 )
            {
                Console.WriteLine("Biciesto");
            }
            else if ( anio % 400 == 0 )
            {
                Console.WriteLine("Biciesto");
            }
            else
            {
                Console.WriteLine("No biciesto");
            }
            */

            Console.WriteLine();
            //3

            /*int CANT_ELEMENTOS = 20;
            int[] fibronacci = new int[CANT_ELEMENTOS];


            for (int i = 0; i < CANT_ELEMENTOS; i++)
            {
                if (i == 0)
                {
                    fibronacci[i] = 0;
                }
                else if (i == 1)
                {
                    fibronacci[i] = 1;
                }
                else
                { 
                    fibronacci[i] = fibronacci[i - 2] + fibronacci[i - 1];
                }
            }
            int acum = new int();
            for (int i = 0; i < CANT_ELEMENTOS; i++)
            {
                acum += fibronacci[i];
            }
            Console.WriteLine(acum);
            */

            //4
            /*
            for (int i = 1; i < 100; i++)
            { 
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */



            //5

            /*Dictionary<string, int> meses = new Dictionary<string, int>()
            {
                { "enero", 1 },
                { "febrero", 2 },
                { "marzo", 3 },
                { "abril", 4 }
            };
            // faltarian los demas meses...
            string op = Console.ReadLine();

            Console.WriteLine(meses[op]);

            Console.ReadKey(); */


            //8
            /*
            string Password = "abcd";

            int tries = 0;

            while ( tries < 4 )
            {

                tries += 1;
                string password = Console.ReadLine();
                if (password == Password)
                {
                    Console.WriteLine("Clave correcta");
                    break;
                }


            }
            */
            //9
            /*
            int filas = Convert.ToInt32(Console.ReadLine());
            string init = "*";
            int k = 1;
            for (int i = 0; i < filas; i++)
            {
                System.Console.SetCursorPosition(30-k, 5+k);
                Console.WriteLine(init);
                init += "**";
                k += 1;
            }
            
            */

            //6

            /*List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < 100)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
           
            for (int i = 0; i < 50; i+=2)
            {
                Console.WriteLine("{0};{1}", (int)primes[i], (int)primes[i+1]);
            }*/


            //5 - falto

            
            Console.ReadKey();


        }
    }
}

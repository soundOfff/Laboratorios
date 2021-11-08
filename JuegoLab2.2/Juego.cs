using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JuegoLab2._2
{
    class Juego
    {
        // record array de jugadas?
        private List<Jugada> _jugadas = new List<Jugada>();

        private int PreguntarMaximo()
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }

        private int PreguntarNumero()
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
        private Jugada continuarJugando(Jugada continuarJugada)
        {
            Console.WriteLine("Ingrese adivinanza");
            continuarJugada.Adivino = PreguntarMaximo();
            continuarJugada.Intentos++;
            while (continuarJugada.Comparar() == false)
            {
                Console.WriteLine("Fallaste! intenta de nuevo");
                continuarJugada.Adivino = PreguntarMaximo();
                continuarJugada.Intentos++;
            }
            Console.WriteLine("Lo lograste en {0}", continuarJugada.Intentos);
            return continuarJugada;
        }
        private Jugada CompararRecord()
        {
            Jugada mejorJugada = _jugadas.OrderBy((v) => v.Intentos).FirstOrDefault();
            // ordena la lista por menor intento y obtiene el primer menor intento
            return mejorJugada;
        }

        public void ComenzarJuego()
        {
            string start;
            Console.WriteLine("Desea comenzar el juego yes/no");
            start = Console.ReadLine();
            while (start == "yes")
            {
                Console.WriteLine("Ingrese el maximo random");
                int maxNum = PreguntarMaximo();
                Jugada newJuego = new Jugada(maxNum);
                Jugada finalizarJuego = continuarJugando(newJuego);
                _jugadas.Add(finalizarJuego);
                Console.WriteLine("Desea comenzar juego yes/no");
                start = Console.ReadLine();
            }
                Console.WriteLine();
                Jugada mejorJugada = CompararRecord();
                Console.WriteLine("La mejor jugada fue la que tuvo {0} intentos", mejorJugada.Intentos);
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace JuegoConAyudaLab2._2
{
    public class Juego
    {
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
        private JugadaConAyuda continuarJugando(JugadaConAyuda continuarJugada)
        {
            Console.WriteLine("Ingrese adivinanza");
            continuarJugada.Adivino = PreguntarMaximo();
            bool bandera = continuarJugada.Comparar();
            continuarJugada.Intentos++;
            while (bandera == false)
            { 
                Console.WriteLine("Fallaste! intenta de nuevo");
                continuarJugada.Adivino = PreguntarMaximo();
                bandera = continuarJugada.Comparar();
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
                JugadaConAyuda newJuego = new JugadaConAyuda(maxNum);
                JugadaConAyuda finalizarJuego = continuarJugando(newJuego);
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

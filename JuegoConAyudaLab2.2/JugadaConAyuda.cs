using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoConAyudaLab2._2
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {
        }

        public override bool Comparar()
        {
            if (_adivino == _numero)
            {
                return true;
            }
            else
            {
                if (Math.Abs(_numero - _adivino) >= 50)
                {
                    Console.WriteLine("El numero esta muy lejos(50)");
                }
                else if (Math.Abs(_numero - _adivino) <= 5)
                {
                    Console.WriteLine("El numero esta cerca(5)");
                }
                return false;
            }
        }

    }
}

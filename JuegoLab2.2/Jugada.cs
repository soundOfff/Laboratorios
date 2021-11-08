using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoLab2._2
{
    class Jugada
    {
        private int _adivino;
        private int _intentos;
        private int _numero;

        public int Adivino
        {
            get
            {
                return _adivino;
            }
            set
            {
                _adivino = value;
            }
        }
        public int Intentos
        {
            get
            {
                return _intentos;
            }
            set
            {
                _intentos = value;
            }
        }
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }
        
        public bool Comparar()
        {
            if(_adivino == _numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

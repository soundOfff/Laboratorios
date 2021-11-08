using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JuegoConAyudaLab2._2
{
    class Jugada
    {
        protected int _adivino;
        private int _intentos;
        protected int _numero;

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
        
        public virtual bool Comparar()
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

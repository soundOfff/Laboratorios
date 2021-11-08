using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private float[] lados;


        public Triangulo(float[] aLados)
        {
            lados = aLados;
        }

        public float CalcularPerimetro()
        {
            float acum = 0;
            foreach ( float a in lados)
            {
                acum += a;
            }
            return acum;
        }

        public float CalcularSuperficie()
        {
            return (lados[0] * lados[1]) / 2;
            // supuse que el usuario ingresaba base en 0 y altura en 1
        }
    }
    public class Circulo
    {

        private int m_radio;

        public int Radio
        {
            get
            {
                return m_radio;
            }
            set
            {
                m_radio = value;
            }
        }


        public int CalcularPerimetro()
        {
            return (int)(2 * Math.PI * m_radio);
        }

        public int CalcularSuperfie()
        {
            return (int)(Math.PI * m_radio * m_radio);
        }
    }

    public class Cuadrado : Rectangulo
    {
        public Cuadrado(float[] aLados) : base(aLados)
        {
        }
    }

    public class Rectangulo : Poligono
    {
        public Rectangulo(float[] aLados) : base(aLados)
        {
        }
    }

    public class Poligono
    {
        private float[] lados;

        public Poligono(float[] aLados)
        {
            lados = aLados;
        }

        public float CalcularPerimetro()
        {
            float acum = 0;
            foreach (float item in lados)
            {
                acum += item;
            }
            return acum;
        }

        public float CalcularSuperficie()
        {
            
                float acum = 0;
                foreach (float item in lados)
                {
                    acum *= item;
                }
                return acum;
            
        }
    }
}
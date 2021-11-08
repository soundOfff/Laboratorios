using System;
using System.Collections.Generic;
using System.Text;

namespace PersonaLab2._2
{
    class Persona
    {
        /*
         Nombre
        Apellido
        Edad
        DNI
        */
        public string nombre;
        private string apellido;
        private int edad;
        private int dni;

        public string Nombre { 
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public string Dni
        {
            get
            {
                return Dni;
            }
            set
            {
                Dni = value;
            }
        }

        public Persona(string name, string lastName, int age, int Dni)
        {
            Console.WriteLine("Se instancio persona");
            nombre = name;
            apellido = lastName;
            edad = age;
            dni = Dni;
        }
        ~Persona()
        {
            Console.WriteLine("Invocando destructor");
        }

        public string getFullName()
        {
            return nombre + apellido;
        }
        
        public int getAge()
        {
            return edad;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Persona
    {
        public string Nombre;
        public string DNI;

        public Persona(string nombre, string dni)
        {
            Nombre = nombre;
            DNI = dni;
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre + ", DNI: " + DNI);
        }

    }
}

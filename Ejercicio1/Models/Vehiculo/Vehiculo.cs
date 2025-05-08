using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Vehiculo
    {
        public string Categoria;
        public string Patente;

        public Vehiculo(string categoria, string patente)
        {
            Categoria = categoria;
            Patente = patente;
        }

        public void Imprimir()
        {
            Console.WriteLine("Categoría: " + Categoria + ", Patente: " + Patente);
        }

    }
}

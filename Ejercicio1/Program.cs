using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ejercicio1.Models.Persona ejemplo_nombre = new Ejercicio1.Models.Persona("Jorge", "38.476.536");
            Ejercicio1.Models.Vehiculo ejemplo_vehiculo = new Ejercicio1.Models.Vehiculo("Auto", "AB530CB");

            ejemplo_nombre.Imprimir();
            ejemplo_vehiculo.Imprimir();
            Console.ReadKey();
        }
    }
}

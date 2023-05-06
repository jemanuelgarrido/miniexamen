
using Ejercicioenclase4_interfases.Misinterfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Interfaces.Mis_Clases
{
    internal class ClsPersona : Ipersona 
    {

        public ClsPersona(string nombre, int edad)
        {
        }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void cumplirAños()
        {
            Console.WriteLine("Hoy es mi cumpleaños");
            Edad++;
            Console.WriteLine($"Mi edad actual es de: ");

        }

        public void DecirMiNombre()
        {
            Console.WriteLine($"Mi nombre es .");
        }

        public void DecirNombre()
        {
            throw new NotImplementedException();
        }
    }
}
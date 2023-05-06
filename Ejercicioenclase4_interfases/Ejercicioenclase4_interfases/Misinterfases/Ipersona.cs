using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Interfaces.Mis_Interfaces
{
    internal interface IPersona
    {
        String Nombre { get; }
        int Edad { get; }
        void DecirMiNombre();
        void cumplirAños();
    }
}

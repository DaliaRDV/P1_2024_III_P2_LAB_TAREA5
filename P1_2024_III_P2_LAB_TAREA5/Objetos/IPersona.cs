using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2024_III_P2_LAB_TAREA5.Objetos
{
    public interface IPersona
    {
        string Nombre { get; set; }

        void Agregar();
        void MostrarInformacion();
    }
}

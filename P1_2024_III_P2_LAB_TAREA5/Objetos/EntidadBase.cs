using System;
using static System.Console;


namespace P1_2024_III_P2_LAB_TAREA5.Objetos
{
    internal abstract class EntidadBase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public virtual void Agregar()
        {
            WriteLine("Agregando entidad base...");
        }

        public virtual void Buscar()
        {
            WriteLine("Buscando entidad base...");
        }

        public virtual void Listar()
        {
            WriteLine("Listando entidades base...");
            ReadLine();
        }
    }
}

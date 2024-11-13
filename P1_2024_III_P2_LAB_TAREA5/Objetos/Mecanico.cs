using System;
using static System.Console;


namespace P1_2024_III_P2_LAB_TAREA5.Objetos
{
    internal class Mecanico : EntidadBase, IPersona, IEmpleado
    {
        public DateTime FechaContratacion { get; set; }

        public override void Agregar()
        {
            base.Agregar();
            WriteLine("Ingrese el nombre del mecánico: ");
            Nombre = ReadLine();
            WriteLine("Ingrese la fecha de contratación del mecánico (dd/MM/yyyy): ");
            FechaContratacion = DateTime.Parse(ReadLine());
        }

        public decimal CalcularSalario()
        {
            throw new NotImplementedException();
        }

        public void MostrarInformacion()
        {
            WriteLine($"Mecánico: {Nombre}, Fecha de Contratación: {FechaContratacion.ToShortDateString()}");
        }

        public void RealizarTarea()
        {
            WriteLine($"{Nombre} está realizando una tarea.");
        }
    }
}

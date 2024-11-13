using System;
using static System.Console;


namespace P1_2024_III_P2_LAB_TAREA5.Objetos
{
    internal sealed class Vehiculo : EntidadBase
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public override void Agregar()
        {
            base.Agregar();
            WriteLine("Ingrese la marca del vehículo: ");
            Marca = ReadLine();
            WriteLine("Ingrese el modelo del vehículo: ");
            Modelo = ReadLine();
        }
    }
}

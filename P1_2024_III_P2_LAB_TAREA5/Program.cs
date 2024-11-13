using P1_2024_III_P2_LAB_TAREA5.Objetos;
using System;
using static System.Console;

namespace P1_2024_III_P2_LAB_TAREA5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();

            while (true)
            {
                WriteLine("    Menú Principal       ");
                WriteLine("1. Agregar Cliente       ");
                WriteLine("2. Agregar Vehículo      ");
                WriteLine("3. Agregar Mecánico      ");
                WriteLine("4. Agregar Servicio      ");
                WriteLine("5. Agregar Repuestos     ");
                WriteLine("6. Generar Factura       ");
                WriteLine("7. Salir                 ");
                WriteLine("   Seleccione su opción: ");

                if (int.TryParse(ReadLine(), out int opcion))
                {
                    if (opcion == 7)
                        break;

                    IPersona persona = null;

                    switch (opcion)
                    {
                        case 1:
                            persona = new Cliente();
                            persona.Agregar();
                            break;
                        case 2:
                            EntidadBase vehiculo = new Vehiculo();
                            vehiculo.Agregar();
                            break;
                        case 3:
                            persona = new Mecanico();
                            persona.Agregar();
                            break;
                        case 4:
                            Servicio servicio = new Servicio();
                            servicio.Agregar();
                            factura.AgregarServicio(servicio);
                            break;
                        case 5:
                            Repuestos repuesto = new Repuestos();
                            repuesto.Agregar();
                            factura.AgregarRepuesto(repuesto);
                            break;
                        case 6:
                            factura.Agregar();
                            break;
                        default:
                            WriteLine("Opción no válida. Presione cualquier tecla para continuar.");
                            ReadKey();
                            break;
                    }
                }
                else
                {
                    WriteLine("Entrada no válida. Presione cualquier tecla para continuar.");
                    ReadKey();
                }
                ReadLine();
            }
        }
    }
}

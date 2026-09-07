/*
Menú interactivo para Ejercicio 3: Herencia Simple
Permite probar la clase Coche que hereda de Vehiculo y usa los métodos arrancar, detener y conducir.
*/
using System;

class Program
{
    static void Main()
    {
        var coche = new Coche();

        while (true)
        {
            Console.WriteLine("\n--- Ejercicio 3: Coche (Herencia) ---");
            Console.WriteLine("1. Arrancar vehículo");
            Console.WriteLine("2. Detener vehículo");
            Console.WriteLine("3. Conducir");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Opción inválida, intente de nuevo.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    coche.Arrancar();
                    break;
                case 2:
                    coche.Detener();
                    break;
                case 3:
                    coche.Conducir();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opción fuera de rango, intente de nuevo.");
                    break;
            }
        }
    }
}
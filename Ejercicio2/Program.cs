/*
Menú interactivo para Ejercicio 2: Encapsulación y Control de Acceso
Permite probar la clase Empleado con validación de nombre y edad a través de propiedades.
*/
using System;

class Program
{
    static void Main()
    {
        var empleado = new Empleado();

        while (true)
        {
            Console.WriteLine("\n--- Ejercicio 2: Empleado ---");
            Console.WriteLine("1. Establecer nombre");
            Console.WriteLine("2. Establecer edad");
            Console.WriteLine("3. Mostrar información");
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
                    Console.Write("Nombre: ");
                    empleado.Nombre = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Edad: ");
                    if (int.TryParse(Console.ReadLine(), out int edad))
                        empleado.Edad = edad;
                    break;
                case 3:
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Edad: {empleado.Edad}");
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
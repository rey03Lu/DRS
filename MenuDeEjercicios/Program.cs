/*
Menú selector interactivo para la Guía POO DRS.
Permite elegir qué ejercicio ejecutar (1-5) y vuelve al menú tras cada uno.
Secuencial, misma terminal.
*/
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menú de Ejercicios POO ===");
            Console.WriteLine("1. Ejercicio 1: Abstracción de Datos (CuentaBancaria)");
            Console.WriteLine("2. Ejercicio 2: Encapsulación y Control de Acceso (Empleado)");
            Console.WriteLine("3. Ejercicio 3: Herencia Simple (Coche)");
            Console.WriteLine("4. Ejercicio 4: Polimorfismo (Animal/Perro/Gato)");
            Console.WriteLine("5. Ejercicio 5: Herencia Multinivel (Animal→Mamifero→Perro)");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione un ejercicio: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EjecutarEjercicio("Ejercicio1", "CuentaBancaria");
                    break;
                case "2":
                    EjecutarEjercicio("Ejercicio2", "Empleado");
                    break;
                case "3":
                    EjecutarEjercicio("Ejercicio3", "Coche");
                    break;
                case "4":
                    EjecutarEjercicio("Ejercicio4", null);
                    break;
                case "5":
                    EjecutarEjercicio("Ejercicio5", null);
                    break;
                case "0":
                    Console.WriteLine("\nSaliendo del menú...");
                    Thread.Sleep(1000);
                    return;
                default:
                    Console.WriteLine("\nOpción inválida, pulse una tecla...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void EjecutarEjercicio(string ejercicio, string? claseEspecifica)
    {
        Console.WriteLine($"\n--- Ejecutando {ejercicio} ---");
        try
        {
            // Construir el comando: dotnet run --project ../EjercicioN
            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"run --project ../{ejercicio}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = Process.Start(psi);
            if (process != null)
            {
                // Leer output del ejercicio mientras se ejecuta
                string? output;
                while (!process.StandardOutput.EndOfStream)
                {
                    output = process.StandardOutput.ReadLine();
                    if (output != null)
                        Console.WriteLine(output);
                }
                process.WaitForExit();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al ejecutar {ejercicio}: {ex.Message}");
        }

        Console.WriteLine($"\n--- {ejercicio} finalizado ---");
        Console.WriteLine("Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}
/*
Menú interactivo para Ejercicio 4: Polimorfismo
Demuestra polimorfismo usando una referencia de tipo Animal para llamar a HacerSonido()
en instancias de Perro y Gato.
*/
using System;

class Program
{
    static void Main()
    {
        // Crear instancias de Perro y Gato
        Perro perro = new Perro();
        Gato gato = new Gato();

        // Usar referencias de tipo Animal para demostrar polimorfismo
        Animal animal1 = perro;
        Animal animal2 = gato;

        while (true)
        {
            Console.WriteLine("\n--- Ejercicio 4: Polimorfismo ---");
            Console.WriteLine("1. Hacer sonido (perro)");
            Console.WriteLine("2. Hacer sonido (gato)");
            Console.WriteLine("3. Salir");
            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Opción inválida, intente de nuevo.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    // A través de referencia Animal, se llama la versión override de Perro
                    animal1.HacerSonido();
                    break;
                case 2:
                    // A través de referencia Animal, se llama la versión override de Gato
                    animal2.HacerSonido();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opción fuera de rango, intente de nuevo.");
                    break;
            }
        }
    }
}
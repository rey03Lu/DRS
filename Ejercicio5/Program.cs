/*
Menú interactivo para Ejercicio 5: Herencia multinivel
Demuestra la jerarquía Animal -> Mamifero -> Perro y el uso de métodos heredados y sobrescritos.
*/
using System;

class Program
{
    static void Main()
    {
        // Crear instancia de Perro (accede a los 3 niveles de herencia)
        var perro = new Perro();

        while (true)
        {
            Console.WriteLine("\n--- Ejercicio 5: Herencia multinivel ---");
            Console.WriteLine("1. Hacer sonido (Perro override)");
            Console.WriteLine("2. Alimentar (heredado de Mamifero)");
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
                    // Perro hereda de Mamifero que hereda de Animal, y sobrescribe HacerSonido()
                    perro.HacerSonido();
                    break;
                case 2:
                    // Mamifero hereda HacerSonido() de Animal y añade Alimentar()
                    perro.Alimentar();
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
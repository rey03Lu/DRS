/*
Menú interactivo para Ejercicio 1: Abstracción de Datos
Permite probar la clase CuentaBancaria con operaciones de depósito, retiro y consulta de saldo.
*/
using System;

class Program
{
    static void Main()
    {
        var cuenta = new CuentaBancaria();

        while (true)
        {
            Console.WriteLine("\n--- Ejercicio 1: Cuenta Bancaria ---");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Consultar saldo");
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
                    Console.Write("Monto a depositar: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal monto1))
                        cuenta.Depositar(monto1);
                    break;
                case 2:
                    Console.Write("Monto a retirar: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal monto2))
                        cuenta.Retirar(monto2);
                    break;
                case 3:
                    Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");
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
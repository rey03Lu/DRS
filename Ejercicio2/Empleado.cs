/*
Ejercicio 2: Encapsulación y Control de Acceso
*/
using System;

class Empleado {
    // Atributos privados para evitar el acceso directo.
    private string nombre;
    private int edad;

    // Propiedad para nombre
    public string Nombre {
        // Metodo Get de Nombre
        get { return nombre; }
        // Metodo Set de Nombre
        set { nombre = value; }
    }

    // Propiedad para edad
    public int Edad {
        // Metodo Get de Edad
        get { return edad; }
        // Metodo Set de Edad
        set {
            if (value > 0 && value < 100) {
                edad = value;
            }
            else {
                Console.WriteLine("La edad debe ser mayor que 0 y menor que 100.");
            }
        }
    }
}
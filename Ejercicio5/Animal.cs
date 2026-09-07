/*
Clase base Animal con método virtual HacerSonido().
Punto de inicio de la jerarquía de herencia.
*/
using System;

class Animal
{
    // Método virtual que será heredado y sobrescrito
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido genérico.");
    }
}
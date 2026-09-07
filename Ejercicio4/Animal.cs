/*
Clase base Animal con método virtual HacerSonido().
Define el comportamiento base que serán sobrescrito por las clases derivadas.
*/
using System;

class Animal
{
    // Método virtual que puede ser sobrescrito por clases derivadas
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido genérico.");
    }
}
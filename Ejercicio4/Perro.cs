/*
Clase derivada Perro que sobrescribe el método HacerSonido().
Demuestra polimorfismo al proporcionar una implementación específica de perro.
*/
class Perro : Animal
{
    // Sobrescribe el método virtual de la clase base
    public override void HacerSonido()
    {
        Console.WriteLine("El perro dice: Guau guau!");
    }
}
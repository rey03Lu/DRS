/*
Clase derivada Gato que sobrescribe el método HacerSonido().
Demuestra polimorfismo al proporcionar una implementación específica de gato.
*/
class Gato : Animal
{
    // Sobrescribe el método virtual de la clase base
    public override void HacerSonido()
    {
        Console.WriteLine("El gato dice: Miau!");
    }
}
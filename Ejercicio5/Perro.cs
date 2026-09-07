/*
Clase derivada Perro que hereda de Mamifero y sobrescribe HacerSonido().
Demuestra herencia multinivel: Perro -> Mamifero -> Animal.
*/
class Perro : Mamifero
{
    // Sobrescribe el método virtual de Animal
    public override void HacerSonido()
    {
        Console.WriteLine("El perro dice: Guau guau!");
    }

    // Hereda Alimentar() de Mamifero sin modificar
}
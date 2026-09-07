/*
Clase intermedia Mamifero que hereda de Animal y añade un método Alimentar().
Conecta la jerarquía entre Animal y Perro.
*/
class Mamifero : Animal
{
    // Método específico de mamíferos
    public void Alimentar()
    {
        Console.WriteLine("El mamífero se alimenta.");
    }
}
using System;

namespace miercoles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenidisimo");
            {
                Mueble mu = new Mueble();
                mu.Color = "cafe";
                mu.Tamaño = "grande";
                mu.Tipo = "mesa";
                Console.WriteLine($"color = {mu.Color}");
                Console.WriteLine($"tamaño = {mu.Tamaño}");
                Console.WriteLine($"tipo = {mu.Tipo}");
                mu.modificar("negro", "silla");
                mu.imprimirmueble();
            }
            Console.ReadLine();
        }
    }
}

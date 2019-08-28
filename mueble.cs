using System;
using System.Collections.Generic;
using System.Text;

namespace miercoles
{

    class Mueble
    {
        public string Tipo { get; set; }

        public string Color { get; set; }

        public string Tamaño { get; set; }

        public Mueble()
        {

        }

        public Mueble(string tipo, string color, string tamaño)
        {
            Tipo = tipo;
            Color = color;
            Tamaño = tamaño;
        }

        public Mueble(string tipo, string tamaño)
        {
            Tipo = tipo;
            Tamaño = tamaño;
        }
        #region metodos
        public void ingresarmueble()
        {
            Console.WriteLine("ingrese color");
            Color = Console.ReadLine();
            Console.WriteLine("ingrese tamaño");
            Tamaño = Console.ReadLine();
            Console.WriteLine("ingrese tipo");
            Tipo = Console.ReadLine();


        }
        
        public void imprimirmueble()
        {
            Console.WriteLine($"color: {Color}");
            Console.WriteLine($"tamaño = {Tamaño}");
            Console.WriteLine($"tipo = {Tipo}");
        }

        #endregion

        public void modificar(string color, string tipo)
        {
            Color = color;
            Tipo = tipo;
        }


    }

}

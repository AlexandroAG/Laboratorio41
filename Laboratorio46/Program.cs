using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio46
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite el radio del Circulo:");
            double radio = double.Parse(Console.ReadLine());

            double area = radio * Math.Pow(radio, 2) * Math.PI;

            Console.WriteLine($"El area del circulo es : {area}");

        }
    }

}
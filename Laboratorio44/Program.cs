﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio44
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del Estudiante: ");
            float score = float.Parse(Console.ReadLine());

            if (score >= 70) 
            { 
              Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha aprobado");
            
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha reprobado, debe repetir.");
            }

        }
    }
}
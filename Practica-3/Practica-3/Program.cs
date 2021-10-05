﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> calificaciones = new List<float>();

            //entrada de datos
            calificaciones.Add(5);
            calificaciones.Add(5);
            calificaciones.Add(10);
            calificaciones.Add(8);
            calificaciones.Add(3);
            calificaciones.Add(4);
            calificaciones.Add(2);
            calificaciones.Add(1);
            calificaciones.Add(20);
            calificaciones.Add(1);
            //mostramos matriz original
            Console.WriteLine("****************** MATRIZ CALIFICACIONES ********************\n");
            for (int i = 0; i < calificaciones.Count; i++)
            {
                Console.Write(  calificaciones[i] + " ");
            }

            //usuario modifica los elementos de la matriz
            Console.WriteLine("\n\nModifique e ingrese la calificaciones correctas para los elementos [8], [9] y [1]");
            Console.WriteLine("calificacion [8]:");
            float ocho = float.Parse(Console.ReadLine());
            Console.WriteLine("calificacion [9]:");
            float nueve = float.Parse(Console.ReadLine());
            Console.WriteLine("calificacion [1]:");
            float uno = float.Parse(Console.ReadLine());
            calificaciones[8] = ocho;
            calificaciones[9] = nueve;
            calificaciones[1] = uno;

            //promedio
            var promedio = calificaciones.Average();
            Console.WriteLine("\nEl promedio es de: " + promedio);
        }
    }
}

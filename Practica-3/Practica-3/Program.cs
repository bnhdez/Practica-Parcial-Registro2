using System;
using System.Collections.Generic;

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

            //Sumar las notas
            float suma = 0;

            foreach (float nota in calificaciones)
                suma += nota;
            //Escribir los resultados
            Console.WriteLine();
            Console.WriteLine("El promedio es de " + suma / calificaciones.Count);

            //valores maximos y minimos
            int max = (int)calificaciones[0], min = (int)calificaciones[0];
            for (int j = 0; j < ; j++)
            {
                if (calificaciones[j] >= max)

                    max = (int)calificaciones[j];


                else if (calificaciones[j] < min)

                    min = (int)calificaciones[j];
            }
            Console.Write("\n\nLa mayor calificacion es: " + max);
            Console.Write("\n\nLa minima calificacion es: " + min + "\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para simplificar lineas de codigo usamos la coleccion Linq que nos ayudara con el promedio, valores minimos y maximos, y la moda
            List<float> calificaciones = new List<float> {5,5,10,8,3,4,2,1,20,1};
            
            //mostramos matriz original
            Console.WriteLine("****************** MATRIZ CALIFICACIONES ****************************\n");
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

            //valores maximos y minimos
            var maximo = calificaciones.Max();
            var minimo = calificaciones.Min();
            Console.WriteLine("La nota maxima es: " + maximo);
            Console.WriteLine("La nota minima es: " + minimo);

            //moda
            var mode = calificaciones.GroupBy(n => n).
                OrderByDescending(g => g.Count()).
                Select(g => g.Key).FirstOrDefault();
            Console.WriteLine(("La moda es: " + mode));

            //Imprimimos nuevos resultados
            Console.WriteLine();
            Console.WriteLine("****************** NUEVA MATRIZ DE CALIFICACIONES ***************************\n");
            for (int i = 0; i < calificaciones.Count; i++)
            {
                Console.Write(calificaciones[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

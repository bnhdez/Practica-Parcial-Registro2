using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nElmentos;
            Console.Write("Digite numero de elementos de la matriz:");
            nElmentos = int.Parse(Console.ReadLine());
            int[] m = new int[nElmentos]; // crear la matriz 

            // llenar la matriz 
            Console.WriteLine("Introducir los valores de la matriz");
            for (int i = 0; i < nElmentos; i++)
            {
                Console.Write("m[" + i + "]=");
                m[i] = int.Parse(Console.ReadLine());
            }

            //valores maximos y minimos
            int max = m[0], min = m[0];
            for (int j = 0; j < m.Length; j++)
            {
                    if (m[j] >= max)

                    max = m[j];


                else if (m[j] < min)

                    min = m[j];
            }
            Console.Write("\n\nEl tamaño de la matriz es: " + m.Length);
            Console.Write("\n\nEl valor maximo es: " + max);
            Console.Write("\n\nEl valor minimo es: " + min + "\n");
        }
    }
}

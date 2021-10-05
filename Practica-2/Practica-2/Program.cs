using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nElmentos;
            Console.Write("Digite numero de elementos de la matriz:");
            nElmentos = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[nElmentos]; // crear la matriz 
            int i = 0; //subindices 

            // llenar la matriz 
            Console.WriteLine("Introducir los valores de la matriz");
            for (i = 0; i < nElmentos; i++)
            {
                Console.Write("m[" + i + "]=");
                m[i] = Convert.ToInt32(Console.ReadLine());
            }

            //ver elementos de una matriz 
            Console.WriteLine();
            for (i = 0; i < nElmentos; i++)
            {
                Console.Write(m[i] + "");
            }
        }
    }
}

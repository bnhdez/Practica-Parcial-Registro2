using System;
using System.Collections;

public class Example

{

    public static void Main()

    {
        //Metodo sin parametro ni tipo
        Euro();

        //Metodo que devuelve un tipo
        double l;
        l = Libra_E();
        Console.WriteLine("Equivale a $" + l);

        //Metodo con parametro
        double dinero;
        Console.WriteLine("Ingrese la cantidad en yenes: "); dinero = double.Parse(Console.ReadLine());
        Yen(dinero);

        //Metodo #1
        static void Euro()
        {
            Console.WriteLine("Ingrese la cantidad en euros: "); double euros = double.Parse(Console.ReadLine());
            double conversion;
            conversion = euros * 1.16;
            Console.WriteLine(euros + " euros equivalen a $" + conversion);
        }

        //Metodo #2
        static double Libra_E()
        {
            Console.WriteLine("Ingrese la cantidad en libras esterlinas: "); double esterlina = double.Parse(Console.ReadLine());
            double conversion;
            conversion = esterlina * 1.36;
            return conversion;
        }

        //Metodo #3
        static void Yen(double yen)
        {
            double conversion;
            conversion = yen * 0.0090;
            Console.WriteLine("{0} yenes equivalen a ${1}", yen, conversion);
        }
    }
}
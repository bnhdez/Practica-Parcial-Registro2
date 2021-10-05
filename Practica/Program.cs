using System;
using System.Collections;

public class Example

{

    public static void Main()

    {

        ArrayList estudiantes = new ArrayList();

        estudiantes.Add("Juan");

        estudiantes.Add("Maria");

        estudiantes.Add("Pdro");

        estudiantes.Add("Luis");

        estudiantes[2] = "Pedro";

        for (int i = 0; i < estudiantes.Count; i ++)

        {

            Console.WriteLine("Estudiante {0} es \"{1}\"", i,

                estudiantes[i]);

        }

    }

}
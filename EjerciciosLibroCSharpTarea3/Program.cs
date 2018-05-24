using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharpTarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EjerciciosLibroCSharpTarea3.Capítulo_9.Ejercicios1_3_4 c = new Capítulo_9.Ejercicios1_3_4();
            c.NueveUno();
            c.NueveTres();
            c.NueveCinco();*/

            EjerciciosLibroCSharpTarea3.Capítulo_10.Estudiantes e = new Capítulo_10.Estudiantes("Maria Pérez", 15, "Femenino", "Pimentel", "Tercero", "(829-456-1230)");
            e.ToString();
            Console.ReadKey();
        }
    }
}

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
            EjerciciosLibroCSharpTarea3.Menu m = new EjerciciosLibroCSharpTarea3.Menu();
            m.Menus();
            string resp;
            do
            {
                Console.WriteLine("\nDesea volver al Menu si o no:  \nDigite: \n's' Para SI\n'n' Para NO");
                resp = Console.ReadLine();
                if (resp == "s")
                {
                    Console.Clear();
                    m.Menus();
                }
                else if (resp == "n")
                    System.Environment.Exit(-1);
            } while (resp != "n");
            Console.ReadKey();
        }
    }
}

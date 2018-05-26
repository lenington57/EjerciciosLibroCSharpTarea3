using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharpTarea3
{
    public class Menu
    {
        public void Menus()
        {
            int resp;
            Console.WriteLine("Ejercicios de los Capítulos 9, 10 y 12 del libro de CSharp de la primera tarea de Lenington del Orbe...");
            Console.WriteLine("\n1. Ejercicios del Noveno Capítulo.\n2. Ejercicios del Decimo Capítulo.\n3. Ejercicios del Decimo Segundo Capítulo.\n4.Salir.");
            Console.WriteLine("\nDigite el número de la opción deseada: ");
            resp = Convert.ToInt32(Console.ReadLine());
            if (resp == 1)
            {
                Console.Clear();
                int r;
                Capítulo_9.Ejercicios1_3_4 c = new Capítulo_9.Ejercicios1_3_4();
                Console.WriteLine("\n1. Ejercicio 1.\n2. Ejercicio 3.\n3. Ejercicio 5.\n4. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        c.NueveUno();
                        break;
                    case 2:
                        Console.Clear();
                        c.NueveTres();
                        break;
                    case 3:
                        c.NueveCinco();
                        break;
                    case 4:
                        break;
                }
            }
            else if (resp == 2)
            {
                Console.Clear();
                int r;
                Capítulo_10.Ejercicios10 c = new Capítulo_10.Ejercicios10();
                Console.WriteLine("\n1. Ejercicio 1.\n2. Ejercicio 2.\n3. Ejercicio 5.\n4. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Estos ejercicios no se tenían que programar, solo implenetar su estructura...");
                        break;
                    case 4:
                        break;
                }
            }

            else if (resp == 3)
            {
                Console.Clear();
                int r;
                Capítulo_12.EjerciciosTodos c = new Capítulo_12.EjerciciosTodos();
                Console.WriteLine("\n1. Ejercicio 3.\n2. Ejercicio 4.\n3. Ejercicio 5.\n3. Salir.\nDigite el número de la opción deseada: ");
                r = Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Excepciones que pueden ocurrir cona arreglos: \nIndexOutOfRangeException\nArgumentNullException\nArgumentOutOfRangeException\nArgumentNullException" +
                            "\nRankException\nInvalidOperationException");                       
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("La función miembro de stream exceptions() toma un parámetro representando los bits de estado para los que usted quiere lanzar la excepcion. Siempre que el stream encuentra este estado,este lanza una excepcion de tipo std::ios_base::failure, que hereda de std::exceptionn");
                        break;
                    case 3:
                        break;
                }
            }

            else if (resp == 4)
                System.Environment.Exit(-1);
        }
    }
}

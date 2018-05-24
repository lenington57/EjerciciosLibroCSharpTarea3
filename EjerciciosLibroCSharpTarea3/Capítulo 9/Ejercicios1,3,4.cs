using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharpTarea3.Capítulo_9
{
    public class Ejercicios1_3_4
    {

        //Ejercicio 1... Creando la estructura para alamacenar los datos de unmproducto de una tienda

        public struct ProductosTienda
        {//Creando la estructura a la que llamaré "ProductosTienda" con los datos de los productos
            int IdProducto;
            string NombreProducto;
            float Precio;
            float CantDisponible;

            //Igualando cada campo de la estructura con su igual en el constructor 
            public ProductosTienda(int id, string nombreP, float precio, float CantD)
            {
                //Llevamos a cabo la asignación
                IdProducto = id;
                NombreProducto = nombreP;
                Precio = precio;
                CantDisponible = CantD;
            }

            //Aquí estoy sobreescribiendo el método "ToString" para imprimir con mi orden deseado los campos
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Id: {0}\nNombre: {1}\nPrecio: {2}\nCantidad: {3}\n", IdProducto, NombreProducto, Precio, CantDisponible);
                return (sb.ToString());
            }
        }

        //Uso este metodo para crear instancias de la estructura e imprimirlas por pantalla 
        public void NueveUno()
        {
            Console.WriteLine("Listado de Productos de la Tienda:\n");
            ProductosTienda pt = new ProductosTienda(1,"Salami",180f,25f);//Instancia para producto "Salami"
            ProductosTienda p = new ProductosTienda(2, "Jamón", 90f, 53f);//Instancia para producto "Jamón"
            Console.WriteLine(pt.ToString());//Imprimir instancia por pantalla llamando el método "ToString" en el comando de salida
            Console.WriteLine(p.ToString());//Imprimir instancia por pantalla llamando el método "ToString" en el comando de salida
        }



        //Ejercicio 3... Creamos estructuras anidadas para imprimir datos de una Persona y su Mascota

        //Creamos la estructura para "Mascota" con los datos que puede tener una mascota
        public struct Mascota
        {
            public string NombreMascota;
            string TipoMascota;
            int EdadMascota;
            string GeneroMascota;

            //Asignamos los datos de Mascota con los obtenidos en el constructor
            public Mascota(string nombreM, string tipoM, int edadM, string generoM)
            {
                //Llevamos a cabo la asignación
                NombreMascota = nombreM;
                TipoMascota = tipoM;
                EdadMascota = edadM;
                GeneroMascota = generoM;
            }

            //Sobreescribimos el método "ToString" para el formato de la impresión por pantalla de los datos de la estructura
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nDatos de su Mascota: \nNombre: {0} \nAnimal: {1} \nEdad: {2} años \nGenero: {3}\n", NombreMascota, TipoMascota, EdadMascota, GeneroMascota);
                return (sb.ToString());
            }
        }

        //Creamos la estructura de Persona
        public struct Persona
        {
            string Nombre;
            int Edad;
            string Genero;
            Mascota mascota;

            //Asignamos los valores en el constructor
            public Persona(string nombre, int edad, string genero, string nombreM, string tipoM, int edadM, string generoM)
            {
                //Llevamos a cabo la asignación
                Nombre = nombre;
                Edad = edad;
                Genero = genero;

                //Hacemos una instancia de Mascota para poder asignar sus valores recibidos al constructor de Persona
                mascota = new Mascota(nombreM, tipoM, edadM, generoM);
            }
           
            //Sobreescribir el método "ToString()" para el formato de impresión de nuestra cadena
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nNombre : {0}\nEdad: {1} años\nGenero: {2}\n", Nombre, Edad, Genero);

                //Adicionamos la cadena obtenida de la estructura "Mascota"
                sb.Append(mascota.ToString());
                return (sb.ToString());
            }
        }

        //En este método creamos las intancias de Persona y agregamos los datos de "Mascota". 
        public void NueveTres()
        {
            Console.WriteLine("Personas y  sus Mascotas:\n");
            Persona p = new Persona("Juan", 20, "Hombre", "Tom", "Perro", 2, "Macho");
            Console.WriteLine(p.ToString());
            Persona p1 = new Persona("Juana", 40, "Mujer", "Dina", "Gato", 3, "Hembra");
            Console.WriteLine(p1.ToString());
        }


        //Ejercicio 4... Crear un enum para los distintos tipos de Neumáticos que existen 

        //Declaro el enum al cual le pongo por nombre "Neumaticos"
        enum Neumaticos
        {
            //Los valores que tendrá, los cominezo en 1
            NeumaticosDeVerano = 1, NeumaticosDeInvierno, NeumaticosAllSeasons, NeumaticosCoche,
            NeumaticosFurgoneta, Neumaticos4x4, NeumaticosPerfilBajo, NeumaticosPerfilAlto,
            NeumaticosRunflat, NeumaticosTubuless, NeumaticosRecauchados, NeumaticosVerdes,
            NeumaticosRadiales, NeumaticosDiagonales
        };

        //En este método instancio al enum e imprimo por pantalla
        public void NueveCinco()
        {
            Neumaticos neumatico;//Crenado la instancia
            neumatico = Neumaticos.NeumaticosCoche;//Asignandole un valor de la instancia al objeto
            Console.WriteLine("Tipo de Neumático usado: {0}", neumatico);//Imprimo el objeto
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharpTarea3.Capítulo_10
{
    public class Ejercicios10
    { }

    //Eejercicio 1

    //Creando el diseño de una clase para llevar el inventario de una tienda.
    public class ProductosTienda
    {
        //Declaramos los datos que utilizaremos en la clase
        private float CantArtVendidos;
        private float PrecioArtVendidos;
        private float GastosConsegArt;
        private float ImpuestoArt;

        //Constructor de la clase
        public ProductosTienda()
        {
            //Inicializando los datos de la clase
            CantArtVendidos = 0;
            PrecioArtVendidos = 0;
            GastosConsegArt = 0;
            ImpuestoArt = 0;
        }

        //creando las propiedades de lectura y escritura para "CantArtVendidos"
        public float GetCantArtVendidos()//Lectura
        {
            return CantArtVendidos;
        }
        public void SetCantArtVendidos(float cantArtVendidos)//Escritura
        {
            this.CantArtVendidos = cantArtVendidos;
        }

        //creando las propiedades de lectura y escritura para "PrecioArtVendidos"
        public float GetPrecioArtVendidos()//Lectura
        {
            return PrecioArtVendidos;
        }
        public void SetPrecioArtVendidos(float precioArtVendidos)//Escritura
        {
            this.PrecioArtVendidos = precioArtVendidos;
        }

        //creando las propiedades de lectura y escritura para "GastosConsegArt"
        public float GetGastosConsegArt()//Lectura
        {
            return GastosConsegArt;
        }
        public void SetGastosConsegArt(float gastosConsegArt)//Escritura
        {
            this.GastosConsegArt = gastosConsegArt;
        }

        //creando las propiedades de lectura y escritura para "ImpuestoArt"
        public float GetImpuestoArt()//Lectura
        {
            return ImpuestoArt;
        }
        public void SetImpuestoArt(float impuestoArt)//Escritura
        {
            this.ImpuestoArt = impuestoArt;
        }

        //Hacemos el meétodo "Inventario"
        public float Inventario()
        {
            float ganancias = 0;
            ganancias = (CantArtVendidos * PrecioArtVendidos) - (GastosConsegArt + ImpuestoArt);
            return ganancias;
        }
    }


    //Eejercicio 2

    //Creando el diseño de una clase para llevar el inventario de una tienda.

    public class Estudiantes
    {
        //Declaramos los datos que utilizaremos en la clase
        private string NombreCompleto;
        private int Edad;
        private string Genero;
        private string Direccion;
        private string Grado;
        private string NoTelefonoPadres;

        //Constructor de la clase
        public Estudiantes()
        {
            //Inicializando los datos de la clase
            NombreCompleto = string.Empty;
            Edad = 0;
            Direccion = string.Empty;
            Grado = string.Empty;
            NoTelefonoPadres = string.Empty;
        }

        public Estudiantes(string nombreCompleto, int edad, string genero, string direccion, string grado, string noTel)
        {
            this.NombreCompleto = nombreCompleto;
            this.Edad = edad;
            this.Genero = genero;
            this.Direccion = direccion;
            this.Grado = grado;
            this.NoTelefonoPadres = noTel;
        }

        //creando las propiedades de lectura y escritura para "NombreCompleto"
        public string GetNombreCompleto()//Lectura
        {
            return NombreCompleto;
        }
        public void SetNombreCompleto(string nombreCompleto)//Escritura
        {
            this.NombreCompleto = nombreCompleto;
        }

        //creando las propiedades de lectura y escritura para "Edad"
        public int GetEdad()//Lectura
        {
            return Edad;
        }
        public void SetEdad(int edad)//Escritura
        {
            this.Edad = edad;
        }

        //creando las propiedades de lectura y escritura para "Genero"
        public string GetGenero()//Lectura
        {
            return Genero;
        }
        public void SetGenero(string genero)//Escritura
        {
            this.Genero = genero;
        }

        //creando las propiedades de lectura y escritura para "Direccion"
        public string GetDireccion()//Lectura
        {
            return Direccion;
        }
        public void SetDireccion(string direccion)//Escritura
        {
            this.Direccion = direccion;
        }

        //creando las propiedades de lectura y escritura para "Grado"
        public string GetGrado()//Lectura
        {
            return Grado;
        }
        public void SetGrado(string grado)//Escritura
        {
            this.Grado = grado;
        }

        //creando las propiedades de lectura y escritura para "Grado"
        public string GetNoTelefonoPadres()//Lectura
        {
            return NoTelefonoPadres;
        }
        public void SetNoTelefonoPadres(string noTel)//Escritura
        {
            this.NoTelefonoPadres = noTel;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre : {0}\nEdad: {1} años\nGenero: {2}\nDireccion: {3}\nGrado: {4}\nNo. de Teléfono de sus Padres: {5}", NombreCompleto, Edad, Genero, Direccion, Grado, NoTelefonoPadres);
            return (sb.ToString());
        }
        //Estudiantes e = new Estudiantes("Maria Pérez", 15, "Femenino", "Pimentel", "Tercero", "(829-456-1230)");
    }

    public class Poligono
    {
        //Declarando los datos de modo privado para que solo puedan ser afectados en esta clase
        private float Ancho;
        private float Largo;
        private float Alto;
        private float Radio;
        private float Lado;

        //Sobrecargando constructor
        public Poligono(float ancho, float largo)
        {
            this.Ancho = ancho;
            this.Largo = largo;
        }

        //Sobrecargando constructor
        public Poligono(float ancho, float largo, float alto)
        {
            this.Ancho = ancho;
            this.Largo = largo;
            this.Alto = alto;
        }

        //Sobrecargando constructor
        public Poligono(float radio)
        {
            this.Radio = radio;
        }

        //Creando las propiedades para el dato "Ancho"
        public float GetAncho()
        {
            return Ancho;
        }
        public void SetAncho(int ancho)
        {
            //Validamos que el dato ingresado sea correcto
            if (ancho <= 0)
                Ancho = 1;
            else
                this.Ancho = ancho;
        }

        ////Creando las propiedades para el dato "Largo"
        public float GetLargo()
        {
            return Largo;
        }
        public void SetLargo(int largo)
        {
            //Validamos que el dato ingresado sea correcto
            if (largo <= 0)
                Largo = 1;
            else
                this.Largo = largo;
        }

        ////Creando las propiedades para el dato "Alto"
        public float GetAlto()
        {
            return Alto;
        }
        public void SetAlto(int alto)
        {
            //Validamos que el dato ingresado sea correcto
            if (alto <= 0)
                Alto = 1;
            else
                this.Alto = alto;
        }

        //Creando las propiedades para el dato "Radio"
        public float GetRadio()
        {
            return Radio;
        }
        public void SetRadio(int radio)
        {
            //Validamos que el dato ingresado sea correcto
            if (radio <= 0)
                Radio = 1;
            else
                this.Radio = radio;
        }

        //Creando las propiedades para el dato "Lado"
        public float GetLado()
        {
            return Lado;
        }
        public void SetLado(int lado)
        {
            //Validamos que el dato ingresado sea correcto
            if (lado <= 0)
                Lado = 1;
            else
                this.Lado = lado;
        }

        //Programando el metodo ToString() para usarse en esta clase: "Pilogono"
        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Ancho: " + Ancho.ToString() + "Largo" + Largo.ToString()
            + " Alto: " + Alto.ToString() + "Radio: " + Radio.ToString() + "Lado : " + Lado.ToString();
            return mensaje;
        }
    }
}
using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //Declaracon de variables de texto capturando dese la terminal 
            string? nombre;
            string? apellido;

            //Declaracin de variables de texto desde codigo
            string? Codigo_estudiantil = "u20220220";
            string? becado = "Si";

            //Declaracion de variables de tpo enteras capturando desde la terminal 
            int edad;

            //Declaracion e variables de tipo enteras desde el codigo 
            int AñoIngreso = 2022;
            int AñoEgreso = 2024;

            //Declaracion de variables decimales capturando desde la terminal 
            double mensualidad;

            //Declaracon de variables decimales desde codigo 
            double transporte = 2.50;
            double alimenacion = 3.75;

            //Declaracion de variables de tiempo o time 
            DateTime FechaActual = DateTime.Now;
            DateTime FechaEspecifica = DateTime(23, 8, 19, 16, 20, 00 );


            //Obtencion de datos desde la terminal 
            Console.WriteLine ("Ingrese su nombre:")
            nombre = convet.ToString(Console.ReadLine());
            Console.WriteLin();

            Console.WriteLine ("Ingrese su apellido:")
            apellido = convet.ToString(Console.ReadLine());
            Console.WriteLin();

            Console.WriteLine ("Ingrese su edad:")
            edad = convet.ToInt32(Console.ReadLine());
            Console.WriteLin();

            Console.WriteLine ("Ingrese su mensualdad universitaria:")
            mensualidad = convet.ToDouble(Console.ReadLine());
            Console.WriteLin();

            //Imprmiendo datos 
            Console.WriteLine("********Incicio de impresion********");
            Console.WriteLine("Su nombre: " + nombre);
            Console.WriteLine("Su apellido es: " + apellido);
            Console.WriteLine("Su codigo estuiantil es: " + codigo_estudiantil);
            Console.WriteLine("Es becado? " + becado);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su año de ingeso fue: " + AñoIngreso );
            Console.WriteLine("Su año de egreso sera: " + AñoEgreso);
            Console.WriteLine("Su mensualidad uniersitaria es: " + "$" + mensualidad);
            Console.WriteLine("Su gasto diario de transporte es: " + "$" + transporte);
            Console.WriteLine("Su gasto diario de alimentacion es: " + "$" + alimenacion);
            Console.WriteLine("La fecha y el tiempo de impresion de datos es " + FechaActual);
            Console.WriteLine("La fecha que termina la practica es: " + FechaEspecifica);
            Console.WriteLine("******** Fin de impresion ********");

            //APLICACION DE FUNCINESS DE CADENA

            //Funcion de oparacion cadens de texto 
            bool cadenaComparativa= nombre == pellido;

            //funcon de minuscula 
            string? FuncionMinuscula1 = nombre.ToUpper();
            string? FuncionMinuscula2 = apellido.ToUpper();

            //funcion de concatenado
            string? cadenaConcatenada = nombre + " " + apellido;

            //Funcon de tamaño de cadena 
            int LongitudCadena1=nombre.Lenght;
            int LongitudCadena2=apellido.Lenght;

            Console.WriteLine("********Inicio de impresion*********");
            Console.WriteLine("Comparacion: " + cadenaComparativa);
            Console.WriteLine("Mayuscula Nombre y Apellido: " + FuncionMayuscula1 + " " + FuncionMinuscula2);
            Console.WriteLine("Miniscula Nombre y Apellido: " + FuncionMinuscula1 + " " + FuncionMinuscula2);
            Console.WriteLine("concatenacion: " + cadenaConcatenada);
            Console.WriteLine("La logitud de datos de nombre es : " + LongitudCadena1);
            Console.WriteLine("La logitud de datos de apellido es : " + LongitudCadena2);
            Console.WriteLine("********Fin de impresion*********");
           
        }
    }
}

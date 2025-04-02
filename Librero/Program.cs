using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Problema:
            Supongamos que estás creando un programa para administrar una biblioteca. 
             * Cada libro tiene un título, un autor y un número de páginas.
             * Queremos crear una clase Libro que represente esta información 
             * y nos permita realizar algunas operaciones básicas. */


            string opcion;
            int id = 1; 
            Libro libro = new Libro(); //Se manda a llamar constructor aunque no haya. aqui se crea el objeto


            do
            {
                Console.WriteLine("Seleccione la opcion que desee\n");
                Console.WriteLine("Opcion 1: Ingresar libro");
                Console.WriteLine("Opcion 2: Consulta de libro por ID");
                Console.WriteLine("Opcion 3: Consulta de libro por titulo");
                Console.WriteLine("Opcion 4: Consulta de libro por Autor");
                Console.WriteLine("Opcion 5: salir de sistema");
                 opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        libro.nuevo(id); //Debemos de pasar una valor 
                        id++;
                        break;
                    case "2":
                        libro.consultaId();
                        break;
                    case "3":
                        libro.consultaTitulo();
                        break;
                    case "4":
                        libro.consultaAutor();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Numero invalido revise bien");
                        break;

                }
            } while(opcion!="5");

        }
    }

    class Libro {
        //Argumnetos son la variables que vamos a declarar.
        string titulo;
        string autor;
        int numeroPaginas;
        int id;

        //Metodos son lo que queremos que haga el programa.

         public void nuevo(int _id) 
        {
            //libro libro = new libro();  //Crea un clase de tipo libro (Instanciarla)

            id = _id;
            Console.WriteLine("Registre el nuevo libro \n");
            Console.WriteLine("Escriba el nombre del autor");
            autor = Console.ReadLine();  //Si esta adentro no necesitamo libro.titulo
            Console.WriteLine("Escriba el nombre del titulo del libro");
            titulo = Console.ReadLine();
            Console.WriteLine("Escriba el nombre el numero de paginas");
            numeroPaginas = int.Parse(Console.ReadLine()); //Da posible error por el tipo de variable.
        } 

        public void consultaId()
        {
            Console.WriteLine("El libro consultados es \n");
            Console.WriteLine("Titulo del ID: " + id);
            Console.WriteLine("Titulo del libro: " + titulo);
            Console.WriteLine("Autor del libro: " + autor);
            Console.WriteLine("Numero de paginas del libro: " + numeroPaginas);
        }
        public void consultaAutor() 
        {
            Console.WriteLine("El libro consultados es \n");
            Console.WriteLine("Titulo del ID: " + id);
            Console.WriteLine("Titulo del libro: " + titulo);
            Console.WriteLine("Autor del libro: " + autor);
            Console.WriteLine("Numero de paginas del libro: " + numeroPaginas);
        }
        
        public void consultaTitulo ()
        {
            Console.WriteLine("El libro consultados es \n");
            Console.WriteLine("Titulo del ID: " + id);
            Console.WriteLine("Titulo del libro: " + titulo);
            Console.WriteLine("Autor del libro: " + autor);
            Console.WriteLine("Numero de paginas del libro: " + numeroPaginas);
        }
    }
}

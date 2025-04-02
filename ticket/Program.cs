using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionalidades Bus = new funcionalidades();
            string nuevo;
            int id = 1;
            do
            {
                Console.WriteLine("\nSeleccione la opcion que desee");
                Console.WriteLine("Opcion 1 Crear ticket");
                Console.WriteLine("Opcion 2 imprimir ticket");
                Console.WriteLine("opcion 3 salir de sistema");
                nuevo = Console.ReadLine();
                switch(nuevo)
                {
                    case "1":
                        Bus.Llenar(id);
                        id++;
                        break;
                    case "2":
                        Bus.Imprimir();
                        break;
                    default:
                        break;
                }

            }while(nuevo!="3");




        }
        
    }
    class ticket
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string area { get; set; }
        public DateTime fecha { get; set; }
        public string DescripcionFalla { get; set; }
    }

    class funcionalidades
    {
        ticket Boleto = new ticket();
        public void Llenar(int _id)
        {
            Boleto.id = _id;
            Console.WriteLine("\nIntroduzca nombre usuario");
            Boleto.usuario = Console.ReadLine();
            Console.WriteLine("Introduzca el area");
            Boleto.area = Console.ReadLine();
            Boleto.fecha = DateTime.Now;
            Console.WriteLine("Introduzca la falla");
            Boleto.DescripcionFalla = Console.ReadLine();
        }
        public void Imprimir()
        {
            Console.WriteLine("\nId de registro:" + Boleto.id);
            Console.WriteLine("Usuario: " + Boleto.usuario);
            Console.WriteLine("La fecha de falla es:" + Boleto.fecha);
            Console.WriteLine("La falla es:" + Boleto.DescripcionFalla);
        }
    }
}

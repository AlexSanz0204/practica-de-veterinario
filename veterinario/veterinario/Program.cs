using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinario.entidades;
using veterinario.negocio;

namespace veterinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veterinario Alex");
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Ingreso de Datos de la mascota: ");
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Elije una opción:\n" +
                "\n1. -Gato" +
                "\n2.- Perro" +
                "\n3.- Salir\n");

            string s1 = null;

            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    Console.WriteLine("Gato");
                    break;

                case "2":
                    Console.WriteLine("Perro");
                    break;

                case "3":
                    Console.WriteLine("Salir");
                    break;

                default:
                    Console.WriteLine("No se selecciono ninguna opción.");
                    break;
            }

            Console.ReadKey();

            //GATO

            ClsGato clsgato = new ClsGato();
            NClsGato nclsgato = new NClsGato();

            Console.WriteLine("Por favor, Ingrese el nombre de su gato: ");
            Console.WriteLine(" ");
            string nombre_gato = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese la raza de su gato; ");
            Console.WriteLine(" ");
            string raza_gato = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese la edad de su gato: ");
            Console.WriteLine(" ");
            int edad_gato = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese el Peso de su gato: ");
            Console.WriteLine(" ");
            double peso_gato = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Selecciona el sexo de su gato: (varón(V), Hembra(H)");
            Console.WriteLine(" ");
            string sexo_gato = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese la Sintomatología que presenta su gato: ");
            Console.WriteLine(" ");
            string sintomatología_gato = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            ClsGato gato = new ClsGato(nombre_gato, raza_gato, edad_gato, peso_gato, sexo_gato, sintomatología_gato);
            Console.ReadLine();

            //PERRO

            ClsPerro clsperro = new ClsPerro();
            NClsPerro nclsperro = new NClsPerro();

            Console.WriteLine("Por favor, Ingrese el nombre de su perro: ");
            Console.WriteLine(" ");
            string nombre_perro = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese la raza de su perro; ");
            Console.WriteLine(" ");
            string raza_perro = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Seleccione el sexo de su perro: (varón(V), Hembra(H)");
            Console.WriteLine(" ");
            string sexo_perro = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Ingrese la Sintomatología que presenta su perro: ");
            Console.WriteLine(" ");
            string sintomatología_perro = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(" ");

            ClsPerro perro = new ClsPerro(nombre_perro, raza_perro, sexo_perro, sintomatología_perro);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace TiendaDeInstrumentosMusicales
{



    // Nombre:Yonatan Agustin Chicas Amaya Codigo:U20211000
 
    class Program
    {
        static void Main(string[] args)
        {
            List<Instrumento> instrumentos = new List<Instrumento>();
            string continuar;

            do
            {
                Console.Clear();
                Console.WriteLine("Inventario de tienda Instrumentos Musicales");
                Console.WriteLine("********************************");
                Console.WriteLine("1. Agregar instrumento");
                Console.WriteLine("2. Listar instrumentos");
                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarInstrumento(instrumentos);
                        break;
                    case 2:
                        MostrarInstrumentos(instrumentos);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;
                }

                Console.Write("¿Desea continuar? (si/no): ");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "si");
        }

        public static void AgregarInstrumento(List<Instrumento> instrumentos)
        {
            Console.WriteLine("\nAgregar Nuevo Instrumento");
            Console.WriteLine("************************");
            Console.Write("Ingrese el nombre del instrumento: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el tipo de instrumento (Cuerdas, Viento , Percusion): ");
            string tipo = Console.ReadLine();

            switch (tipo.ToLower())
            {
                case "guitarra":
                    Console.Write("Ingrese el número de cuerdas: ");
                    if (int.TryParse(Console.ReadLine(), out int numeroCuerdas))
                    {
                        Guitarra guitarra = new Guitarra(nombre, tipo, numeroCuerdas);
                        instrumentos.Add(guitarra);
                        Console.WriteLine("\nGuitarra agregada correctamente");
                    }
                    else
                    {
                        Console.WriteLine("Número de cuerdas no válido. La guitarra no fue agregada.");
                    }
                    break;

                case "batería":
                    Console.Write("Ingrese el número de componentes: ");
                    if (int.TryParse(Console.ReadLine(), out int numeroComponentes))
                    {
                        Bateria bateria = new Bateria(nombre, tipo, numeroComponentes);
                        instrumentos.Add(bateria);
                        Console.WriteLine("\nBatería agregada correctamente");
                    }
                    else
                    {
                        Console.WriteLine("Número de componentes no válido. La batería no fue agregada.");
                    }
                    break;

                default:
                    Instrumento instrumento = new Instrumento(nombre, tipo);
                    instrumentos.Add(instrumento);
                    Console.WriteLine("\nInstrumento agregado correctamente");
                    break;
            }

            Console.ReadKey();
        }

        public static void MostrarInstrumentos(List<Instrumento> instrumentos)
        {
            Console.WriteLine("\nLista de Instrumentos:");
            Console.WriteLine("*********************");

            foreach (Instrumento item in instrumentos)
            {
                Console.Write($"{item.Nombre} - {item.Tipo}");

                if (item is Guitarra guitarra)
                {
                    Console.Write($" - Cuerdas: {guitarra.NumeroDeCuerdas}");
                }
                else if (item is Bateria bateria)
                {
                    Console.Write($" - Componentes: {bateria.NumeroDeComponentes}");
                }

                Console.WriteLine();
            }
        }
    }

    public class Instrumento
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Instrumento(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }
    }

    public class Guitarra : Instrumento
    {
        public int NumeroDeCuerdas { get; set; }

        public Guitarra(string nombre, string tipo, int numeroDeCuerdas) : base(nombre, tipo)
        {
            NumeroDeCuerdas = numeroDeCuerdas;
        }
    }

    public class Bateria : Instrumento
    {
        public int NumeroDeComponentes { get; set; }

        public Bateria(string nombre, string tipo, int numeroDeComponentes) : base(nombre, tipo)
        {
            NumeroDeComponentes = numeroDeComponentes;
        }
    }
}

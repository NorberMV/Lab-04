
namespace Class
{
    using System;
    using System.Collections.Generic;

    class Pelota
    {
        public string Tipo { get; set; }
        public double Diametro { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** Programa para ingresar información de pelotas ***");

            int cantidadPelotas;
            do
            {
                Console.Write("Ingrese la cantidad de pelotas: ");
            } while (!int.TryParse(Console.ReadLine(), out cantidadPelotas) || cantidadPelotas <= 0);

            List<Pelota> pelotas = new List<Pelota>();

            for (int i = 0; i < cantidadPelotas; i++)
            {
                Console.WriteLine($"Ingrese la información de la pelota {i + 1}:");

                Pelota pelota = new Pelota();

                Console.Write("Tipo (fútbol, baloncesto, etc.): ");
                pelota.Tipo = Console.ReadLine();
                Console.Write("Diametro (en centímetros): ");
                pelota.Diametro = double.Parse(Console.ReadLine());

                pelotas.Add(pelota);
            }

            Console.WriteLine("\nInformación de las pelotas:");
            foreach (var pelota in pelotas)
            {
                Console.WriteLine($"Tipo: {pelota.Tipo}");
                Console.WriteLine($"Diametro: {pelota.Diametro} cm");
                Console.WriteLine();
            }
        }
    }

}
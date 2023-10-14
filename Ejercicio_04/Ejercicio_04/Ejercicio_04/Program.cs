namespace Class
{
    using System;
    using System.Collections.Generic;

    class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoAnimal { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** Programa para ingresar información de mascotas ***");

            int cantidadMascotas;
            do
            {
                Console.Write("Ingrese la cantidad de mascotas: ");
            } while (!int.TryParse(Console.ReadLine(), out cantidadMascotas) || cantidadMascotas <= 0);

            List<Mascota> mascotas = new List<Mascota>();

            for (int i = 0; i < cantidadMascotas; i++)
            {
                Console.WriteLine($"Ingrese la información de la mascota {i + 1}:");

                Mascota mascota = new Mascota();

                Console.Write("Nombre: ");
                mascota.Nombre = Console.ReadLine();
                Console.Write("Edad: ");
                mascota.Edad = int.Parse(Console.ReadLine());
                Console.Write("Tipo de animal: ");
                mascota.TipoAnimal = Console.ReadLine();

                mascotas.Add(mascota);
            }

            Console.WriteLine("\nDatos de las mascotas:");
            foreach (var mascota in mascotas)
            {
                Console.WriteLine($"Nombre: {mascota.Nombre}");
                Console.WriteLine($"Edad: {mascota.Edad} años");
                Console.WriteLine($"Tipo de animal: {mascota.TipoAnimal}");
                Console.WriteLine();
            }
        }
    }

}
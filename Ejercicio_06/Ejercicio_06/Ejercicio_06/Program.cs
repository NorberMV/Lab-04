
namespace Class
{
    using System;
    using System.Collections.Generic;

    class Restaurante
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<string> Menu { get; set; }

        public Restaurante(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Menu = new List<string>();
        }

        public void AgregarPlatoAlMenu(string plato)
        {
            Menu.Add(plato);
        }

        public void TomarPedido()
        {
            Console.WriteLine("Bienvenido al restaurante. Menú disponible:");

            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu[i]}");
            }

            List<string> pedidos = new List<string>();

            while (true)
            {
                Console.Write("Ingrese el número del plato que desea o '0' para finalizar el pedido: ");
                string input = Console.ReadLine();

                if (input == "0")
                    break;

                if (int.TryParse(input, out int opcion) && opcion >= 1 && opcion <= Menu.Count)
                {
                    pedidos.Add(Menu[opcion - 1]);
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                }
            }

            Console.WriteLine("\nResumen del pedido:");
            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }

            Console.WriteLine("Gracias por su pedido. ¡Buen provecho!");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** Programa de simulación de restaurante ***");

            Console.Write("Ingrese el nombre del restaurante: ");
            string nombreRestaurante = Console.ReadLine();

            Console.Write("Ingrese la dirección del restaurante: ");
            string direccionRestaurante = Console.ReadLine();

            Restaurante restaurante = new Restaurante(nombreRestaurante, direccionRestaurante);

            int cantidadPlatos;
            do
            {
                Console.Write("Ingrese la cantidad de platos en el menú: ");
            } while (!int.TryParse(Console.ReadLine(), out cantidadPlatos) || cantidadPlatos <= 0);

            for (int i = 0; i < cantidadPlatos; i++)
            {
                Console.Write($"Ingrese el nombre del plato {i + 1}: ");
                restaurante.AgregarPlatoAlMenu(Console.ReadLine());
            }

            restaurante.TomarPedido();
        }
    }

}
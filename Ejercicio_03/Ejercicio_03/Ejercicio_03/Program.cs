 namespace Classes
{

    using System;
    using System.Collections.Generic;

    class Factura
    {
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public List<double> ProductosComprados { get; set; }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var producto in ProductosComprados)
            {
                total += producto;
            }
            return total;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** Programa para calcular el total de facturas ***");

            int cantidadFacturas;
            do
            {
                Console.Write("Ingrese la cantidad de facturas: ");
            } while (!int.TryParse(Console.ReadLine(), out cantidadFacturas) || cantidadFacturas <= 0);

            List<Factura> facturas = new List<Factura>();

            for (int i = 0; i < cantidadFacturas; i++)
            {
                Console.WriteLine($"Ingrese la información de la factura {i + 1}:");

                Factura factura = new Factura();
                factura.ProductosComprados = new List<double>();

                Console.Write("Número de Factura: ");
                factura.NumeroFactura = int.Parse(Console.ReadLine());
                Console.Write("Fecha (dd/mm/yyyy): ");
                factura.Fecha = DateTime.Parse(Console.ReadLine());

                int cantidadProductos;
                do
                {
                    Console.Write("Ingrese la cantidad de productos comprados: ");
                } while (!int.TryParse(Console.ReadLine(), out cantidadProductos) || cantidadProductos <= 0);

                for (int j = 0; j < cantidadProductos; j++)
                {
                    Console.Write($"Ingrese el costo del producto {j + 1}: ");
                    factura.ProductosComprados.Add(double.Parse(Console.ReadLine()));
                }

                facturas.Add(factura);
            }

            Console.WriteLine("\nTotal de cada factura:");
            foreach (var factura in facturas)
            {
                double total = factura.CalcularTotal();
                Console.WriteLine($"Factura #{factura.NumeroFactura}: ${total:F2}");
            }
        }
    }



}


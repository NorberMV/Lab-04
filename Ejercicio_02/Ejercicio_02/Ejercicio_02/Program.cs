
namespace Classes
{

    class Avion
    {
        public string Modelo { get; set; }
        public int CapacidadPasajeros { get; set; }
        public int VelocidadMaxima { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacidad de Pasajeros: {CapacidadPasajeros}");
            Console.WriteLine($"Velocidad Máxima: {VelocidadMaxima} km/h");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** Programa para ingresar información de aviones ***");

            int cantidadAviones;
            do
            {
                Console.Write("Ingrese la cantidad de aviones: ");
            } while (!int.TryParse(Console.ReadLine(), out cantidadAviones) || cantidadAviones <= 0);

            Avion[] aviones = new Avion[cantidadAviones];

            for (int i = 0; i < cantidadAviones; i++)
            {
                Console.WriteLine($"Ingrese la información del avión {i + 1}:");

                aviones[i] = new Avion();
                Console.Write("Modelo: ");
                aviones[i].Modelo = Console.ReadLine();
                Console.Write("Capacidad de Pasajeros: ");
                aviones[i].CapacidadPasajeros = int.Parse(Console.ReadLine());
                Console.Write("Velocidad Máxima (km/h): ");
                aviones[i].VelocidadMaxima = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nInformación de los aviones:");
            foreach (var avion in aviones)
            {
                avion.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }

}
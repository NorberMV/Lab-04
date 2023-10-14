
namespace Classes
{

    //Custom class
    internal class Rectangulo
    {
        // Class properties
        public double Ancho { get; set; }
        public double Alto { get; set; }

        //Class constructor
        public Rectangulo(double ancho, double alto)
        {
            // setting class properties
            Ancho = ancho;
            Alto = alto;
        }

        // Definicion de methods
        public double CalcularAreaRectangulo()
        {
            double area = this.Ancho * this.Alto;
            return area;
        }

        public double CalcularPerimetroRectangulo()
        {
            double perimetro = 2*(this.Alto + this.Ancho);
            return perimetro;
        }

    }


    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*** Programa para calcular el área y perimetro de un rectangulo! ***");

            // Receiving the data
            Console.WriteLine("\nPor favor ingrese los datos del Rectangulo a calcular:");

            //Alto
            Console.Write("Alto[m]: ");
            if (double.TryParse(Console.ReadLine(), out double alto)) {
                Console.WriteLine($"Valor recibido de altura: {alto}");
            }
            else
            {
                Console.WriteLine("Valor no permitido, favor ingrese un valor en metros.");
                Console.WriteLine("Saliendo...");
                // To quit the program, use Environment.Exit
                Environment.Exit(0);
            }

            // Ancho
            Console.Write("Ancho[m]: ");
            if (double.TryParse(Console.ReadLine(), out double ancho))
            {
                Console.WriteLine($"Valor recibido de ancho: {ancho}");
            }
            else
            {
                Console.WriteLine("Valor no permitido, favor ingrese un valor en metros.");
                Console.WriteLine("Saliendo...");
                // To quit the program, use Environment.Exit
                Environment.Exit(0);
            }

            // Make the calculations
            ////class instance
            Rectangulo rectangulo = new Rectangulo(ancho, alto);
            double area = rectangulo.CalcularAreaRectangulo();
            double perimetro = rectangulo.CalcularPerimetroRectangulo();
            // Imprimir los resultados
            ImprimirResultados(area, perimetro, ancho, alto);
            Console.ReadKey();
        }

        static void ImprimirResultados(double area, double perimetro, double ancho, double altura)
        {
            Console.WriteLine();
            Console.WriteLine("[ RESULTADOS ]");
            Console.WriteLine($"El área del rectangulo de altura: {altura}m y ancho: {ancho}m es de: {area}m^2");
            Console.WriteLine($"Y su perimetro es de: {perimetro}m");
        }
    }
}
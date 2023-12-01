using System.Drawing;

namespace PrefinalGarateAdolfina.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del triángulo:");

            Console.Write("Lado A: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado B: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado C: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Colores disponibles: Rojo, Azul, Verde");
            Console.Write("Color de relleno: ");
            Color colorRelleno;
            Enum.TryParse(Console.ReadLine(), out colorRelleno);

            Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC, colorRelleno);

            if (triangulo.ValidarTriangulo())
            {
                Repositorio repositorio = new Repositorio("triangulos.txt");
                repositorio.AgregarTriangulo(triangulo);
                Console.WriteLine("Triángulo almacenado correctamente en el archivo.");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
            }
            if (triangulo.ValidarTriangulo())
            {
                Repositorio repositorio = new Repositorio("triangulos.txt");
                repositorio.AgregarTriangulo(triangulo);

                // Mostrar información del triángulo ingresado
                Console.WriteLine("Información del triángulo:");
                Console.WriteLine($"Lado A: {triangulo.LadoA}");
                Console.WriteLine($"Lado B: {triangulo.LadoB}");
                Console.WriteLine($"Lado C: {triangulo.LadoC}");
                Console.WriteLine($"Color de relleno: {triangulo.ColorRelleno}");
                Console.WriteLine($"Perímetro: {triangulo.CalcularPerimetro()}");
                Console.WriteLine($"Área: {triangulo.CalcularArea()}");
                Console.WriteLine($"Tipo de triángulo: {triangulo.TipoTriangulo()}");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("¡Triángulo almacenado correctamente en el archivo!");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
            }


            Console.ReadLine();
        }
    }
}

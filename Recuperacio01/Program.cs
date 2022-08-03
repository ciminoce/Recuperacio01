using System;

namespace Recuperacio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer Ejercicio");
            double perimetro, superficie;
            Console.Write("Ingrese el valor del lado del cuadrado:");
            int lado =int.Parse(Console.ReadLine());
            //perimetro = lado * 4;
            perimetro = CalcularPerimetro(lado);
            //superficie = Math.Pow(lado, 2);
            superficie = CalcularSuperficie(lado);
            Console.WriteLine($"El perímetro es {perimetro}");
            Console.WriteLine($"La superficie es {superficie}");
            Console.ReadLine();

        }


        private static double CalcularPerimetro( int ladoDelCuadrado)
        {
            return ladoDelCuadrado * 4;
        }

        private static double CalcularSuperficie(int ladoDelCuadrado)
        {
            return Math.Pow(ladoDelCuadrado, 2);
        }
    }
}

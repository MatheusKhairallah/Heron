using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Um triângulo qualquer possui 3 lados de medidas 3, 25 e 26. Calcule a área e o semiperim-etro usando o teorema de Heron.");
            int A=3;
            int B=25;
            int C=26;
            int resultado_S=A + B + C;
            int resultado2_S=resultado_S / 2;
           
            int resultado_A=resultado2_S * 24 * 2 * 1;
            double resultado2_A=Math.Sqrt(resultado_A);
            
            Console.ReadKey();
            Console.Clear();
            Console.Write("Semiperimetro=");
            Console.WriteLine($"{resultado2_S}");
            Console.Write("Área=");
            Console.WriteLine($"{resultado2_A}");
        }
    }
}

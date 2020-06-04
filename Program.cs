using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o valor de A, B e C para poder ser feito o cálculo da área e do semiperímetro de um triangulo pela lei de Heron.");
            Console.Write("A:");
            double A=Convert.ToDouble(Console.ReadLine());
            Console.Write("B:");
            double B=Convert.ToDouble(Console.ReadLine());
            Console.Write("C:");
            double C=Convert.ToDouble(Console.ReadLine());
            
            double resultado_S=A + B + C;
            double resultado2_S=resultado_S / 2;
           
            double resultado_A=resultado2_S - A;
            double resultado2_A=resultado2_S - B;
            double resultado3_A=resultado2_S - C;
            double resultado4_A=resultado2_S * resultado_A * resultado2_A * resultado3_A;
            double resultado5_A=Math.Sqrt(resultado4_A);
            
            Console.Clear();
            Console.Write("Semiperimetro=");
            Console.WriteLine($"{resultado2_S}");
            Console.Write("Área=");
            Console.WriteLine($"{resultado5_A}");
        }
    }
}

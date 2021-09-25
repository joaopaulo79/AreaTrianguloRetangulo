using System;

namespace AreaTrianguloRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, a;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Área do Triângulo Retângulo ===\n");
            Console.ResetColor();
            
            Console.WriteLine("Diite a medida da base e da altura\nde seu triângulo.\n");

            Console.Write("Base....: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura..: ");
            h = Convert.ToDouble(Console.ReadLine());

            a = (b * h) / 2;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Resultado ===\n");
            Console.ResetColor();

            Console.WriteLine($"Base..: {b}\nAltura: {h}\n\nÁrea..: {a}\n");
        }
    }
}

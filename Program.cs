using System;

namespace AreaTrianguloRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite a medida da altura do seu triângulo retângulo: ");
            Console.ResetColor();
            string alturaDigitada = Console.ReadLine();
            double altura = Convert.ToDouble(alturaDigitada);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite a medida da base do seu triângulo retângulo: ");
            Console.ResetColor();
            string baseDigitada = Console.ReadLine();
            double baseTotal = Convert.ToDouble(baseDigitada);
            double area = baseTotal * altura / 2;
            Console.WriteLine();
            Console.WriteLine($"Base..: {baseTotal}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine();
            Console.WriteLine($"Área..: {area}");
            Console.WriteLine();
        }
    }
}

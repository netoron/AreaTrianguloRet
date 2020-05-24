using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            string um;
            string altura;
            double soma1;
            double soma2;
            double dois = 2;
             
            double soma;
            double total;
            
            Console.WriteLine("Calcular área do triangulo retangulo");
            Console.Write("Digite a Base:");
            
            um = Console.ReadLine();
            Console.WriteLine("Digite a altura:");
            altura = Console.ReadLine();

            soma1 = Convert.ToDouble(um);
            soma2 = Convert.ToDouble(altura);

            soma = soma1 * soma2;
            total = soma / dois;
            
            Console.WriteLine($"A soma da área é {total}");




        }
    }
}

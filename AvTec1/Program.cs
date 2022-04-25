using System;

namespace AvTec1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor total vendido:");
            string totalValue = Console.ReadLine();
            Console.WriteLine($"Valor da Comissao: R${CalculateCommission(Double.Parse(totalValue))}" +
                              $"\nValor Total: R${CalculateCommission(Double.Parse(totalValue)) + Double.Parse(totalValue)} ");
        }
        static double CalculateCommission(double totalValue)
        {
            if (totalValue >= 16) return totalValue * 0.05;
            else if (totalValue > 10 && totalValue < 15) return totalValue * 0.03;
            else if (totalValue >= 6 && totalValue <= 10) return totalValue * 0.013;
            else return totalValue * 0.004;
        }
    }

}
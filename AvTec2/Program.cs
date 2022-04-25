using System;

namespace AvTec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int hits = 0;
            Console.WriteLine("Digite a quantidade de tentativas: ");
            int attempts = int.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.WriteLine($"---------Tente acertar o Numero---------\nChances: [{attempts}]\t Acertos: {hits}\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Digite um numero inteiro de 1 a 15: ");
                int n = int.Parse(Console.ReadLine());
                if (n > 15)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Numero maior que 15 cara ? vc é besta é ? Tenta de novo ...!");
                    LoadAndClear();
                }
                else
                {
                    int numRand = random.Next(1, 15);
                    if (n == numRand)
                    {
                        Console.WriteLine("AAAAACERTOU MIZERAVI!!!\nINCRIVEEEEL");
                        hits++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                        if (n == (numRand + 1) || n == (numRand - 1)) Console.WriteLine($"NA TRAAAAAAAAAAAVEEEE\n\nSeu Chute: {n}\tResultado: {numRand}");
                        else if (n == (numRand + 2) || n == (numRand - 2)) Console.WriteLine($"FOI QUAAAAASEEEE\n\nSeu Chute: {n}\tResultado: {numRand}");
                        else if (n == (numRand + 3) || n == (numRand - 3)) Console.WriteLine($"QUEN QUEN QUEN QUEN queEeEeEeEenn....\n\nSeu Chute: {n}\tResultado: {numRand}");
                        else if (n == (numRand + 4) || n == (numRand - 4)) Console.WriteLine($"Galvão Bueno: HOJE NÃOOOO!....\n\nSeu Chute: {n}\tResultado: {numRand}");
                        else Console.WriteLine($"ERROU FEIOOO, ERROU RUUUDE \n\nSeu Chute: {n}\tResultado: {numRand}");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\n\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    attempts--;
                    Thread.Sleep(500);
                }
            } while (attempts != 0);
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine($"FIM DE JOGO!\nSeu Resultado foi:\n-----------------------------------------\n{hits} Acerto(s)\tde\t {attempts} Tentativa(s)\n-----------------------------------------");
            Console.ReadKey();
        }
        static void LoadAndClear()
        {
            Console.Write("~~~~~~~~~~~~~~~\nLOADING");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.Clear();
        }
    }
}
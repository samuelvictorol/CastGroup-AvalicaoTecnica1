using System;

namespace AvTec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            RemedyRepository rr = new RemedyRepository();
            bool app = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione a opção:\n1)Listar Remédios Disponíveis\n2)Procurar Remédio\n3)Finalizar app");
                SelectOption(Console.ReadLine(), rr);
            } while (app);
        }
        static void SelectOption(string input, RemedyRepository rr)
        {
            switch (input)
            {
                case "1":
                    OptionOne(rr);
                    break;
                case "2":
                    OptionTwo(rr);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Finalizando app, Volte Sempre!");
                    Console.WriteLine("Pressione qualquer tecla para confirmar");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Inválida!\nPressione qualquer tecla para voltar ao menu inicial");
                    Console.ReadKey();
                    return;
            }
        }

        static void OptionOne(RemedyRepository rr)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Lista de Remédios Disponíveis:\n");
            rr.ShowVariety(1);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static void OptionTwo(RemedyRepository rr)
        {
            Console.Clear();
            Console.WriteLine("Digite qualquer parte do nome do remédio que deseja buscar:\n(ex: Dorflex - flex, or, lex, etc)" +
                              $"\nQuantidade de Remédios Diferentes disponíveis no momento: {rr.ShowVariety(0)}");
            rr.FindMedicine(Console.ReadLine());
            Console.WriteLine("Pressione qualquer tecla para fazer uma nova Busca");
            Console.ReadKey();
        }
    }

}
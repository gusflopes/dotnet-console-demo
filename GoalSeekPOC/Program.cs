// See https://aka.ms/new-console-template for more information

using System;
namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        {
            
            // Exibe as opções para o usuário
            Console.WriteLine("Digite a opção pretendida:");
            Console.WriteLine("1 = Opcao 1");
            Console.WriteLine("2 = Opcao 2");
            Console.WriteLine("3 = Opcao 3");
            Console.WriteLine("0 = Sair");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Escolheu opcao 1");
                    break;
                case "2":
                    Console.WriteLine("Escolheu opcao 2");
                    break;
                case "3":
                    Console.WriteLine("Escolheu opcao 3");
                    break;
                case "4":
                    Console.WriteLine("Escolheu opcao 4");
                    break;
                case "0":
                    return; // Exit
                default:
                Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.WriteLine(); // Adicionar linha
        }
    }
}
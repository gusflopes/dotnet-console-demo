namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            
            Console.WriteLine("Digite a opção pretendida:");

            foreach (var opcao in Opcao.Opcoes)
            {
                Console.WriteLine($"Digite {opcao.Id} para a {opcao.Name}");
            }
            Console.WriteLine("Digite 0 para sair...");
            
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                if (escolha == 0)
                {
                    return; // Sai do Programa
                }

                var opcaoSelecionada = Opcao.Opcoes.FirstOrDefault(o => o.Id == escolha);
                if (opcaoSelecionada != null)
                {
                    // Movido para a função InvokeHandler na classe Opcao
                    // Console.WriteLine($"\n{opcaoSelecionada.Response}");
                    Opcao.InvokeHandler(opcaoSelecionada.Id);
                }
                else
                {
                    Console.WriteLine("\nOpção inválida.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite a opção selecionada.");
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
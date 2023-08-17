namespace ConsoleApp;

public class Opcao
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Response { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Opcao> opcoes = new List<Opcao>
        {
            new Opcao { Id = 1, Name = "Opção 1", Response = "Escolheu a Opção 1" },
            new Opcao { Id = 2, Name = "Opção 2", Response = "Escolheu a Opção 2" },
            new Opcao { Id = 3, Name = "Opção 3", Response = "Escolheu a Opção 3" },
            new Opcao { Id = 4, Name = "Opção 4", Response = "Escolheu a Opção 4" },
        };

        while (true)
        {
            Console.Clear();
            
            Console.WriteLine("Digite a opção pretendida:");

            foreach (var opcao in opcoes)
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

                var opcaoSelecionada = opcoes.FirstOrDefault(o => o.Id == escolha);
                if (opcaoSelecionada != null)
                {
                    Console.WriteLine($"\n{opcaoSelecionada.Response}");
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
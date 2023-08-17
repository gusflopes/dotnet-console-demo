namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> opcoes = new Dictionary<int, string>
        {
            { 1, "Opção 1" },
            { 2, "Opção 2" },
            { 3, "Opção 3" }
        };

        Dictionary<int, string> respostas = new Dictionary<int, string>
        {
            { 1, "Escolheu a Opção 1" },
            { 2, "Escolheu a Opção 2" },
            { 3, "Escolheu a Opção 3" }
        };
        
        while (true)
        {
            Console.Clear();
            
            Console.WriteLine("Digite a opção pretendida:");

            foreach (var opcao in opcoes)
            {
                Console.WriteLine($"Digite {opcao.Key} para a {opcao.Value}");
            }
            Console.WriteLine("Digite 0 para sair...");
            
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                if (escolha == 0)
                {
                    return; // Sai do Programa
                }
                else if (respostas.ContainsKey(escolha))
                {
                    Console.WriteLine($"\n{respostas[escolha]}");
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
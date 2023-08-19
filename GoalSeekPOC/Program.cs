using System.Reflection;

namespace GoalSeekPOC;

class Program
{
    static void Main(string[] args)
    {
        var opcoes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(IOpcao)) && !t.IsInterface ) // && t.IsAbstract
            .Select(t => Activator.CreateInstance(t) as IOpcao)
            .ToList();
        
        while (true)
        {
            Console.Clear();
            
            Console.WriteLine("Digite a opção pretendida:");

            foreach (IOpcao? opcao in opcoes)
            {
                if (opcao != null)
                {
                    Console.WriteLine($"Digite {opcao.Id} para a {opcao.Name}");
                }
            }
            Console.WriteLine("Digite 0 para sair...");
            
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                if (escolha == 0)
                {
                    return; // Sai do Programa
                }

                IOpcao? opcaoSelecionada = opcoes.FirstOrDefault(o => o.Id == escolha);
                if (opcaoSelecionada != null)
                {
                    // Opcao.InvokeHandler(opcaoSelecionada.Id);
                    opcaoSelecionada.InvokeHandler(escolha);
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
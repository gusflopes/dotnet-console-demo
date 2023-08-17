namespace ConsoleApp;

public interface IHandler
{
    void Invoke(int param) {}
}

public class MainHandler : IHandler
{
    public void Invoke(int param)
    {
        Console.WriteLine($"Executando Handler Principal para Opção {param}");
    }
}

public class AlternativeHandler : IHandler
{
    public void Invoke(int param)
    {
        Console.Clear();
        Console.WriteLine($"\nExecutando Handler Secundário para Opção {param}");
        Console.WriteLine($"Digite um comando em texto...");
        while (true)
        {
            string? input = Console.ReadLine();
            if (input == "exit()")
            {
                Console.Clear();
                return; // Sai do Programa
            }

            if (input == "clear()")
            {
                Console.Clear();
            }

            if (input != null)
            {
                // Movido para a função InvokeHandler na classe Opcao
                // Console.WriteLine($"\n{opcaoSelecionada.Response}");
                Console.WriteLine($"Foi digitado o seguinte: {input}");
            }
            Console.WriteLine("\nDigite o comando pretendido ou digite exit() para sair...");
            // Console.ReadKey();
        }
    }
}

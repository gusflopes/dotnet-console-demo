namespace ConsoleApp;

public class Opcao
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Response { get; set; }
    public Action<int> Handler { get; set; }
    
    public static List<Opcao> Opcoes = new List<Opcao>
    {
        new Opcao { Id = 1, Name = "Opção 1", Response = "Escolheu a Opção 1", Handler = HandlerFunc },
        new Opcao { Id = 2, Name = "Opção 2", Response = "Escolheu a Opção 2", Handler = HandlerFunc },
        new Opcao { Id = 3, Name = "Opção 3", Response = "Escolheu a Opção 3", Handler = HandlerAlternativo },
        new Opcao { Id = 4, Name = "Opção 4", Response = "Escolheu a Opção 4", Handler = HandlerAlternativo },
    };

    public static void InvokeHandler(int param)
    {
        var selecionado = Opcoes.FirstOrDefault(o => o.Id == param);
        selecionado.Handler.Invoke(param);
    }
    
    // Métodos estáticos das opções
    public static void HandlerFunc(int param)
    {
        var opcaoSelecionada = Opcoes.FirstOrDefault(o => o.Id == param);
        Console.WriteLine($"\n{opcaoSelecionada.Response}");
        Console.WriteLine("Para chamar essa função foi utilizado o Handler Principal");
    }

    public static void HandlerAlternativo(int param)
    {
        var opcaoSelecionada = Opcoes.FirstOrDefault(o => o.Id == param);
        Console.WriteLine($"\n{opcaoSelecionada.Response}");
        Console.WriteLine("Para chamar essa função foi utilizado o Handler Secundário");
    }
}
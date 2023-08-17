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
        Console.WriteLine($"Executando Handler Secundário para Opção {param}");
    }
}

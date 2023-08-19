namespace ConsoleApp;

public interface IOpcao
{
    int Id { get; }
    string Name { get; }
    string Response { get; }
    void InvokeHandler(int param);
}

public class Opcao1 : IOpcao
{
    private readonly IHandler _handler = new MainHandler();

    public int Id => 1;
    public string Name => "Opção 1";
    public string Response => "Escolheu a Opção 1";
    
    public void InvokeHandler(int param)
    {
        Console.WriteLine($"\n{this.Response}");
        _handler.Invoke(param);
    }
}

public class Opcao2 : IOpcao
{
    private readonly IHandler _handler = new MainHandler();

    public int Id => 2;
    public string Name => "Opção 2";
    public string Response => "Escolheu a Opção 2";
    
    public void InvokeHandler(int param)
    {
        Console.WriteLine($"\n{this.Response}");
        _handler.Invoke(param);
    }
}

public class Opcao3 : IOpcao
{
    private readonly IHandler _handler = new AlternativeHandler();

    public int Id => 3;
    public string Name => "Opção 3";
    public string Response => "Escolheu a Opção 3";
    
    
    public void InvokeHandler(int param)
    {
        Console.WriteLine($"\n{this.Response}");
        _handler.Invoke(param);
    }
}

public class Opcao4 : IOpcao
{
    private readonly IHandler _handler = new AlternativeHandler();

    public int Id => 4;
    public string Name => "Opção 4";
    public string Response => "Escolheu a Opção 4";
    
    public void InvokeHandler(int param)
    {
        Console.WriteLine($"\n{this.Response}");
        _handler.Invoke(param);
    }
}

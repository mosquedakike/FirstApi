namespace FirstWebAPI.Services;

public class HelloWorldService : IHelloWorldservice
{
    public string GetHelloWorld()
    {
        return "Hello world!";
    }
}

public interface IHelloWorldservice
{
    string GetHelloWorld();
}
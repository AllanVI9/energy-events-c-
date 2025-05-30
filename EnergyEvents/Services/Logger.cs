namespace EnergyEvents.Services;

public class Logger
{
    public void RegistrarEvento(string mensagem)
    {
        Console.WriteLine($"[LOG - {DateTime.Now}] {mensagem}");
    }
}
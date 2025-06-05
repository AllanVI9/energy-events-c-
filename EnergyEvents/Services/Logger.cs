namespace EnergyEvents.Services;

/// <summary>
/// Serviço responsável por registrar eventos e mensagens no console passando a data.
/// </summary>
public class Logger
{
    public void RegistrarEvento(string mensagem)
    {
        Console.WriteLine($"[LOG - {DateTime.Now}] {mensagem}");
    }
}
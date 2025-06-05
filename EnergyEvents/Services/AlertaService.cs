namespace EnergyEvents.Services;

/// <summary>
/// Serviço responsável por exibir um alerta de cor vermelha no console.
/// </summary>
public class AlertaService
{
    public void EnviarAlerta(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ALERTA] {mensagem}");
        Console.ResetColor();
    }
}
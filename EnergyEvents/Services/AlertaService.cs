namespace EnergyEvents.Services;

public class AlertaService
{
    public void EnviarAlerta(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ALERTA] {mensagem}");
        Console.ResetColor();
    }
}
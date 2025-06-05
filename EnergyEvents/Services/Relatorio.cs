using EnergyEvents.Models;

namespace EnergyEvents.Services;

public class Relatorio
{
    /// <summary>
    /// Serviço responsável por gerar e exibir status atual dos dispositivos.
    /// </summary>
    private readonly List<Dispositivo> _dispositivos;

    public Relatorio(List<Dispositivo> dispositivos)
    {
        _dispositivos = dispositivos;
    }

    public void ExibirStatus()
    {
        foreach (var d in _dispositivos)
        {
            string status = d.Ligado ? "Ligado" : "Desligado";
            Console.WriteLine($"- {d.Nome} ({(d.Essencial ? "Essencial" : "Não Essencial")}): {status}");
        }
    }
}

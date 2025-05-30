using EnergyEvents.Models;

namespace EnergyEvents.Services;

public class MonitorDeEnergia
{
    private readonly List<Dispositivo> _dispositivos;

    public MonitorDeEnergia(List<Dispositivo> dispositivos)
    {
        _dispositivos = dispositivos;
    }
    
    private double _ultimaTensao;

    public string VerificarTensao(double tensao)
    {
        _ultimaTensao = tensao;
        if (tensao < 100)
        {
            LigarEssenciais();
            DesligarNaoEssenciais();
            return "⚠ Queda de tensão detectada! Equipamentos não essenciais foram desligados.";
        }
        else if (tensao > 240)
        {
            DesligarTodos();
            return "⚠ Sobretensão detectada! Todos os equipamentos foram desligados.";
        }
        else
        {
            LigarTodos();  // liga todos os equipamentos na tensão normal
            return "Tensão normal. Todos os equipamentos foram ligados.";
        }
    }

    private void DesligarNaoEssenciais()
    {
        foreach (var d in _dispositivos.Where(d => !d.Essencial))
            d.Desligar();
    }

    private void DesligarTodos()
    {
        foreach (var d in _dispositivos)
            d.Desligar();
    }

    private void LigarTodos()
    {
        foreach (var d in _dispositivos)
            d.Ligar();
    }
    private void LigarEssenciais()
    {
        foreach (var d in _dispositivos.Where(d => d.Essencial))
            d.Ligar();
    }
    public double ObterUltimaTensao()
    {
        return _ultimaTensao;
    }
}

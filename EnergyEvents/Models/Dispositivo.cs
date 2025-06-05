namespace EnergyEvents.Models;

/// <summary>
/// Representa um dispositivo utilizado no sistema de gerenciamento de energia.
/// </summary>
public abstract class Dispositivo
{
    public string Nome { get; set; }
    public bool Essencial { get; set; }
    public bool Ligado { get; private set; }

    protected Dispositivo(string nome, bool essencial)
    {
        Nome = nome;
        Essencial = essencial;
        Ligado = true;
    }

    public void Desligar() => Ligado = false;
    public void Ligar() => Ligado = true;
}

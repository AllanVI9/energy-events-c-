namespace EnergyEvents.Models;

/// <summary>
/// Representa um dispositivo do tipo essencial no sistema de gerenciamento de energia.
/// Herda da classe base Dispositivo e define a propriedade Essencial como true.
/// </summary>
public class EquipamentoEssencial : Dispositivo
{
    public EquipamentoEssencial(string nome) : base(nome, true) { }
}
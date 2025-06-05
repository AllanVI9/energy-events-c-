using EnergyEvents.Models;
using System;
namespace EnergyEvents.Models;

/// <summary>
/// Representa um dispositivo do tipo não essencial no sistema de gerenciamento de energia.
/// Herda da classe base Dispositivo e define a propriedade Essencial como false.
/// </summary>
public class EquipamentoNaoEssencial : Dispositivo
{
    public EquipamentoNaoEssencial(string nome) : base(nome, false) { }
}
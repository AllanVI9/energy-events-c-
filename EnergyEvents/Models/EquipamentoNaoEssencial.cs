using EnergyEvents.Models;
using System;
namespace EnergyEvents.Models;

public class EquipamentoNaoEssencial : Dispositivo
{
    public EquipamentoNaoEssencial(string nome) : base(nome, false) { }
}
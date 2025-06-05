using EnergyEvents.Models;
using EnergyEvents.Services;
using System;
using System.Collections.Generic;

/// <summary>
/// Classe principal do programa que inicia a execução do sistema de gerenciamento de energia.
/// </summary>
class Program
{
    /// <summary>
    /// Responsável por autenticar o usuário, inicializar os dispositivos e serviços e exibir o menu principal do sistema.
    /// </summary>
    static void Main(string[] args)
    {
        var login = new LoginService();
        if (!login.Autenticar()) return;

        var equipamentos = new List<Dispositivo>
        {
            new EquipamentoEssencial("Concentrador de Oxigênio"),
            new EquipamentoNaoEssencial("Televisão"),
            new EquipamentoNaoEssencial("Luminária")
        };

        var monitor = new MonitorDeEnergia(equipamentos);
        var logger = new Logger();
        var alerta = new AlertaService();
        var relatorio = new Relatorio(equipamentos);
        var falhas = new List<string>();

        var menu = new MenuService(monitor, logger, alerta, relatorio, equipamentos, falhas);
        menu.ExibirMenu();
    }
}

📟 EnergyEvents – Sistema de Monitoramento de Energia

## 🧩 Finalidade do Sistema

**EnergyEvents** é uma aplicação de console desenvolvida em **C#** para simular o monitoramento de dispositivos essenciais e não essenciais frente a variações de tensão elétrica e a voltagem.  
O sistema foi idealizado para demonstrar, de forma didática, como diferentes tipos de equipamentos reagem a tensões instáveis, registrando eventos, falhas e fornecendo relatórios sobre o status atual, tratando com prioridade os aparalhos essenciais.

### Funcionalidades principais:
- Simulação da variação de tensão elétrica
- Ligamento/desligamento automático de dispositivos
- Registro de falhas e eventos
- Cálculo da porcentagem de equipamentos ligados
- Exibição de alertas e geração de relatórios

---

## ▶️ Instruções de Execução

### ✅ Pré-requisitos
- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)

### 🏁 Executar a aplicação
1. Clone ou baixe este repositório:
   ```bash
     git clone https://github.com/seu-usuario/energy-events.git
     cd energy-events

2. Login:
      Usuário: admin
      Senha: 1234

3. Só usar agora.

## 📦 Estrutura de Pastas

/EnergyEvents
│
├── Models/                      # Classes de domínio
│   ├── Dispositivo.cs              # Classe abstrata base
│   ├── EquipamentoEssencial.cs     # Permanece ligado em tensão baixa
│   ├── EquipamentoNaoEssencial.cs  # Desliga com tensão inferior a 110V
│
├── Services/                    # Camada de serviços
│   ├── MonitorDeEnergia.cs         # Verificação de tensão e controle de dispositivos
│   ├── Logger.cs                   # Registro de eventos
│   ├── AlertaService.cs            # Envio de alertas no console
│   ├── Relatorio.cs                # Geração de status dos dispositivos
│   ├── LoginService.cs             # Autenticação do usuário
│   └── MenuService.cs              # Menu e controle de opções do sistema
│
└── Program.cs                   # Ponto de entrada da aplicação

## 💻 Tecnologias Utilizadas

Linguagem: C#

Framework: .NET 6 ou superior

Paradigmas aplicados:
    - Programação Orientada a Objetos (POO)
    - Encapsulamento
    - Herança
    - Separação de responsabilidades (SRP)

# Sistema de Logística para Transportadora

Aplicação de console em C# (.NET) que simula o controle de colaboradores de uma frota
de transporte, aplicando os quatro pilares de POO: abstração, encapsulamento, herança
e polimorfismo.

## Estrutura de pastas

```
LogisticaTransportadora/
├── LogisticaTransportadora.sln
├── integrantes.md
├── README.md
└── LogisticaTransportadora/
    ├── LogisticaTransportadora.csproj
    ├── Program.cs
    ├── Models/
    │   ├── FuncionarioTransporte.cs   (classe base abstrata)
    │   ├── MotoristaCarreta.cs        (classe derivada)
    │   └── EntregadorMoto.cs          (classe derivada)
    ├── Services/
    │   └── FrotaService.cs            (cadastro e listagem polimórfica)
    └── Utils/
        └── ConsoleUI.cs               (helpers de apresentação)
```

## Como os requisitos foram atendidos

| Requisito | Onde está |
|-----------|-----------|
| Classe abstrata que impede instanciação direta | `Models/FuncionarioTransporte.cs` — `public abstract class` |
| Duas classes derivadas | `MotoristaCarreta` e `EntregadorMoto` |
| Encapsulamento de nome e registro | Campos privados + propriedades com `protected set` e validação |
| Construtor na classe base | `protected FuncionarioTransporte(string nome, string registro)` |
| Construtores filhos usando `base` | `: base(nome, registro)` nas duas derivadas |
| Método `virtual MostrarDetalhes()` | Declarado na base, com `override` nas duas filhas |
| Chamadas polimórficas | `FrotaService.ListarDetalhes()` percorre `List<FuncionarioTransporte>` |

## Como executar

**Visual Studio:** abrir `LogisticaTransportadora.sln` e pressionar F5.

**Terminal:**
```bash
cd LogisticaTransportadora
dotnet run
```

> Se o SDK instalado for mais novo, basta trocar `<TargetFramework>net8.0</TargetFramework>`
> no `.csproj` pela versão correspondente (ex.: `net10.0`).

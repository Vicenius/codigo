# Sistema Bancário Básico em C#

Projeto de estudo em C# com uma aplicação de console para praticar classes, objetos, construtores, métodos e interação com o usuário.

## Funcionalidades implementadas

- Criação de uma conta com número e nome do titular.
- Escolha de depósito inicial opcional.
- Depósito e saque.
- Alteração do titular.
- Exibição dos dados da conta e do saldo em formato de moeda brasileira (`pt-BR`).
- No saque, o método subtrai do saldo o valor informado mais uma taxa fixa de R$ 5,00.

## Tecnologias e conceitos

- C# e .NET 10
- Aplicação de console
- Classes, propriedades, construtores e métodos
- Estruturas condicionais e de repetição
- Formatação monetária com `CultureInfo`

## Como executar

Instale o SDK do .NET 10 e execute, na pasta raiz do repositório:

```bash
dotnet run --project Portifolio_1/SistemaBancario.csproj
```

A solução `Portifolio_1.slnx` pode ser aberta em uma versão do Visual Studio compatível com o formato `.slnx`.

## Limitações conhecidas e oportunidades de melhoria

Este é um projeto introdutório e não representa um sistema bancário real. No código publicado, o saque não verifica se há saldo suficiente, então o saldo pode ficar negativo. A taxa de R$ 5,00 é fixa no método `Saque` e não é apresentada ao usuário antes da operação. Entradas numéricas são convertidas com `Parse`; valores inválidos podem encerrar a aplicação com uma exceção. A condição atual de validação das opções do menu não rejeita corretamente valores fora do intervalo esperado. Os valores monetários são armazenados como `double`; uma evolução possível é avaliar o uso de `decimal`. Não há persistência em banco de dados: os dados existem somente durante a execução do programa.

## Sobre o arquivo de projeto

O arquivo `SistemaBancario.csproj` foi baseado no projeto original enviado pelo autor: mantém o alvo `net10.0`, `ImplicitUsings` e `Nullable` habilitados. A referência absoluta `C:\Users\...\Program.cs` do arquivo recebido foi removida para que o projeto use os arquivos locais do repositório e funcione após clonagem. `Program.cs` e `Conta.cs` foram preservados sem alterações.

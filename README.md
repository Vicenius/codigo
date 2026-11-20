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

- C#
- .NET 8 (arquivo `.csproj` mínimo adicionado para tornar publicável o código recebido; o arquivo de projeto original não foi fornecido)
- Aplicação de console
- Classes, propriedades, construtores e métodos
- Estruturas condicionais e de repetição
- Formatação monetária com `CultureInfo`

## Como executar

É necessário ter o SDK do .NET 8 instalado.

```bash
dotnet run --project Portifolio_1/Portifolio_1.csproj
```

A solução `Portifolio_1.slnx` também pode ser aberta em uma versão do Visual Studio compatível com o formato `.slnx`.

## Limitações conhecidas e oportunidades de melhoria

Este é um projeto introdutório e não representa um sistema bancário real. No código publicado:

- O saque não verifica se há saldo suficiente; por isso, o saldo pode ficar negativo.
- A taxa de R$ 5,00 é fixa no método `Saque` e não é apresentada ao usuário antes da operação.
- Entradas numéricas são convertidas com `Parse`; valores inválidos podem encerrar a aplicação com uma exceção.
- A condição atual de validação das opções do menu não rejeita corretamente valores fora do intervalo esperado.
- Os valores monetários são armazenados como `double`; uma evolução possível é avaliar o uso de `decimal`.
- Não há persistência em banco de dados: os dados existem somente durante a execução do programa.

## Sobre os arquivos do projeto

Os arquivos `Program.cs` e `Conta.cs` correspondem ao código fornecido pelo autor e foram copiados sem alterações. O arquivo `Portifolio_1.csproj` foi acrescentado para completar a estrutura executável, pois não estava entre os arquivos recebidos.

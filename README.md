# dotnet-testing-kata-validations

![CI](https://github.com/Cassisilverston/dotnet-testing-kata-validations/actions/workflows/ci.yml/badge.svg)

Projeto de prática orientada a testes utilizando .NET 10 e xUnit, com foco em organização de solução, clareza de regras de negócio e integração contínua.

Este repositório não tem como objetivo resolver um problema complexo, mas sim demonstrar domínio de fundamentos essenciais para desenvolvimento backend profissional: escrita de testes determinísticos, separação de responsabilidades e versionamento limpo.

---

## Contexto/Motivação

Durante minha evolução em .NET, percebi que muitos projetos de estudo focam apenas na implementação da funcionalidade e deixam os testes como etapa secundária.

Este projeto foi construído com a intenção oposta:  
a validação de comportamento é o centro da aplicação.

A biblioteca `Validations` contém regras simples de manipulação de strings e coleções, enquanto o projeto `Validations.Tests` garante a confiabilidade dessas regras através de testes unitários bem definidos.

---

## Objetivos Técnicos

- Exercitar escrita de testes unitários claros e previsíveis
- Aplicar padrão AAA (Arrange, Act, Assert)
- Utilizar `[Theory]` e `[InlineData]` para cenários parametrizados
- Garantir cobertura de cenários positivos, negativos e borda
- Estruturar solução separando domínio e testes
- Configurar pipeline de CI com GitHub Actions

---

## Tecnologias

- .NET 10
- C#
- xUnit
- FluentAssertions
- GitHub Actions

---

## Estrutura do Projeto

```text
/
src/
└── Validations/
    ├── ValidacoesString.cs
    └── ValidacoesLista.cs
tests/
└── Validations.Tests/
    ├── ValidacoesStringTests.cs
    └── ValidacoesListaTests.cs
.github/
└── workflows/
    └── ci.yml
```

---

## Como executar localmente

- Clone o repositório:
```
git clone https://github.com/Cassisilverston/dotnet-testing-kata-validations.git

cd dotnet-testing-kata-validations
```


- Execute os testes:
```
dotnet test
```
Todos os testes devem passar antes de qualquer nova alteração ser considerada válida.

---

## Integração Contínua

O pipeline configurado executa automaticamente:

- Restore
- Build
- Test

A cada `push` ou `pull request` na branch `main`.

Isso garante que nenhuma alteração quebre o comportamento previamente validado.

---

## Decisões Técnicas

- Métodos são estáticos por se tratarem de utilidades puras
- Tratamento explícito para valores `null`
- Uso de `StringComparison.Ordinal` para previsibilidade
- Testes independentes entre si (sem dependência de estado)
- Versionamento sem artefatos de build (`bin/` e `obj/` ignorados)

---

## Evoluções Futuras

- Inclusão de relatório de cobertura de testes
- Aplicação de analyzers e regras de qualidade
- Expansão da biblioteca com novas validações

---

Desenvolvido por Cassiano Silverston.


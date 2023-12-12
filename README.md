# Projeto de Calculadora Simples usando TDD

Este projeto consiste no desenvolvimento de uma calculadora simples utilizando a abordagem de Desenvolvimento Orientado a Testes (TDD). O TDD é uma prática de desenvolvimento de software que consiste em escrever testes antes de implementar o código funcional, garantindo assim que o software atenda aos requisitos especificados e que novas funcionalidades possam ser adicionadas ou alteradas com mais confiança.

O objetivo principal deste projeto é criar uma calculadora capaz de realizar operações básicas, como adição, subtração, multiplicação e divisão. Além disso, buscamos garantir a qualidade do código por meio da implementação de testes unitários.

## Ferramentas e Tecnologias

    Linguagem de programação: C#
    Framework de teste: XUnit
    IDE: Visual Studio, Visual Studio Code (ou qualquer outra de sua preferência)
    Controle de versão: Git

## Esrutura do projeto

    /calculadora-simples_tdd_csharp
    ├── calc
    │   ├── Calculadora.cs   # Código-fonte da calculadora
    |   |-- Program.cs       # Código-fonte da calculadora
    │
    ├── tests
    │   ├── CalculadoraTeste.cs   # Testes unitários para a calculadora
    │
    ├── README.md   # Documentação do projeto
    |
    |-- TddSolution.sln

## Execução dos Testes

Para executar os testes use o comando no terminal:

    dotnet test

##### OBS.: Você deve está no diretório raiz do projeto

## Execução do Programa

Para executar o programa considerando que você esta na raiz do projeto use o comando no terminal:

    cd calc
    dotnet run

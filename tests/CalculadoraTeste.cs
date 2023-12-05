using System;
using System.IO;
using Xunit;

using calc;

namespace calculadora.tests;

public class CalculadoraTeste
{

    private Calculadora calcTeste = new Calculadora();
    private StringReader entradaDoConsole = new StringReader($"{10}\n {2}");
    private StringWriter saidaDoConsole = new StringWriter();
    [Fact]
    public void SomaTeste()
    {

        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Soma();
        decimal resultadoEsperado = 12m;

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void SubtracaoTeste()
    {
        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Subtracao();
        decimal resultadoEsperado = 8m;

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.Equal(resultado, resultadoEsperado);
    }
}
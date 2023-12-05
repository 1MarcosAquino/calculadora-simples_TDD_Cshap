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

    [Fact]
    public void MultiplicacaoTeste1()
    {

        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Multiplicacao();
        decimal resultadoEsperado = 20m;

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.Equal(resultado, resultadoEsperado);

    }

    [Fact]
    public void MultiplicacaoTeste2()
    {
        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Multiplicacao();

        Type resultadoEsperado = typeof(decimal);
        Type tipo = resultado.GetType();

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.Equal(tipo, resultadoEsperado);
    }

    [Fact]
    public void MultiplicacaoTeste3()
    {
        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Multiplicacao();

        Type resultadoEsperado = typeof(int);
        Type tipo = resultado.GetType();

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.NotEqual(tipo, resultadoEsperado);
    }

    [Fact]
    public void DivisaoTeste1()
    {
        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Divisao();
        int resultadoEsperado = 5;

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.Equal(resultado, resultadoEsperado);

    }

    [Fact]
    public void DivisaoTeste2()
    {
        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Divisao();

        Type resultadoEsperado = typeof(decimal);
        Type tipo = resultado.GetType();

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.Equal(tipo, resultadoEsperado);
    }

    [Fact]
    public void DivisaoTeste3()
    {
        Console.SetIn(this.entradaDoConsole);
        Console.SetOut(this.saidaDoConsole);

        decimal resultado = this.calcTeste.Divisao();

        Type resultadoEsperado = typeof(int);
        Type tipo = resultado.GetType();

        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

        Assert.NotEqual(tipo, resultadoEsperado);
    }

}

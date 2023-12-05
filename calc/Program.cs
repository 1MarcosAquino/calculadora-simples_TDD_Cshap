using calc;

Calculadora calc = new Calculadora();

bool finalizar = true;

while (finalizar)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Selecione algum número de 1 a 5:\n");

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("1: Soma\n2: Subtração\n3: Miltiplicação\n4: Divisão\n5: Finalizar\n");

    Console.ForegroundColor = ConsoleColor.Red;
    int.TryParse(Console.ReadLine(), out int numeroSaida);

    switch (numeroSaida)
    {
        case 1:
            decimal soma = calc.Soma();
            Console.WriteLine($"\nResultado: {soma}\n");
            break;

        case 2:
            decimal subtracao = calc.Subtracao();
            Console.WriteLine($"\nResultado: {subtracao}\n");
            break;

        case 3:
            decimal multiplicacao = calc.Multiplicacao();
            Console.WriteLine($"\nResultado: {multiplicacao}\n");
            break;

        case 4:
            decimal divisao = calc.Divisao();
            Console.WriteLine($"\nResultado: {divisao}\n");
            break;

        case 5:
            finalizar = false;
            Console.Write("Finalizado com sucesso!");
            break;

        default:
            Console.WriteLine("Opção desconhecida! Selecione algum número de 1 a 5.\n");
            break;
    }

}
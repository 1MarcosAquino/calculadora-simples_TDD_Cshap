namespace calc
{
    public class Calculadora
    {

        private decimal _num1 = default;
        private decimal _num2 = default;
        private void Entrada()
        {
            string message = this._num1 == default ? "primeiro" : "segundo";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Digite o {message} número: ");

            Console.ForegroundColor = ConsoleColor.Red;
            if (decimal.TryParse(Console.ReadLine(), out decimal num))
            {
                if (message == "primeiro")
                {
                    this._num1 = num;
                    Entrada();
                }
                else
                {
                    this._num2 = num;
                }
            }
            else
            {
                Entrada();
            };

        }
        public decimal Soma()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ADIÇÃO\n");

            this._num1 = default;
            this._num2 = default;

            this.Entrada();

            return this._num1 + this._num2;
        }
        public decimal Subtracao()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SUBTRAÇÂO\n");

            this._num1 = default;
            this._num2 = default;

            this.Entrada();

            return this._num1 - this._num2;
        }

        public decimal Multiplicacao()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MULTIPLICAÇÂO\n");

            this._num1 = default;
            this._num2 = default;

            this.Entrada();

            return this._num1 * this._num2;
        }

        public decimal Divisao()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DIVISÂO\n");

            this._num1 = default;
            this._num2 = default;

            this.Entrada();

            return this._num1 / this._num2;
        }

    }
}
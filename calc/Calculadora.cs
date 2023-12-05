using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calc
{
    public class Calculadora
    {
        
        private int _num1 = default;
        private int _num2 = default;
        private void Entrada()
        {
            string message = this._num1 == default ? "primeiro" : "segundo";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Digite o {message} número: ");

            Console.ForegroundColor = ConsoleColor.Red;
            if (int.TryParse(Console.ReadLine(), out int num))
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
        
       
    }
}
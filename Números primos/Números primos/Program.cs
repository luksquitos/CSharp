using System;

namespace Números_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa irá encontrar todos os números primos até o que você escrever");
            Console.Write("Digite um número :");

            int max = Convert.ToInt16(Console.ReadLine());
            

            for (int a = 1; a <= max; a++)
            {
                int contDivi = 0;
                for (int b = 1; b <= a; b++)
                {
                    if (a % b == 0)
                    {
                        contDivi++;
                    }
                }
                if (contDivi <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"{a} ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{a} ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}

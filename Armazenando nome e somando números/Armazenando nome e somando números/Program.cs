// Mostrando como uma simples coisa em Python em outra linguagem é quase impossível de ser lida.

using System;

namespace Armazenando_nome_e_somando_números
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int n1;
            int n2;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine(); // Essa linha pode ser escrita dessa forma porque é string.
            Console.WriteLine($"Okay, {nome}... Digite 2 números para serem somados: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            var soma = n1 + n2;

            Console.WriteLine($"A soma de {n1} + {n2} é {soma}");


        }
    }
}

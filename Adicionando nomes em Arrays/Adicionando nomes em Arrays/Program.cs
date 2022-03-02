using System;

namespace Adicionando_nomes_em_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos nomes deseja cadastrar: ");
            int num = Convert.ToInt16(Console.ReadLine());
            string[] nomes = new string[num];

            //Cadastrando os nomes
            int totalCadastrados = 0;
            for (int index = 0; index < nomes.Length; index++)
            {
                Console.Write($"{index + 1}º nome: ");
                nomes[index] = Console.ReadLine();
                totalCadastrados += 1;
            }

            //Mostrando os nomes
            Console.WriteLine($"Os {totalCadastrados} nomes cadastrados foram...");
            for (int index = 0; index < nomes.Length; index++)
            {
                Console.WriteLine($"{nomes[index]}");
            }
            
            
        }
    }
}

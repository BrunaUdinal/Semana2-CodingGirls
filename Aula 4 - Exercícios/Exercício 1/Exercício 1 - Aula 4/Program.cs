using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1___Aula_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que solicite a entrada de 10 números pelo usuário, 
             * armazenando-os em um vetor, 
             * e então monte outro vetor com os valores do primeiro multiplicados por 5.*/
           
          
            int[] valores = new int[10];
            int[] multiplicar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Insira o {i + 1}º numero: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
                multiplicar[i] = 5 * valores[i];
            }

            Console.Write("\nValores inseridos: ");
            foreach (int valor in valores)
            {
                Console.Write($"{valor} ");
            }

            Console.Write("\nValores inseridos multiplicados por 5: ");
            foreach (int mult in multiplicar)
            {
                Console.Write($"{mult} ");
                Console.ReadLine();
            }












        }
    }
}

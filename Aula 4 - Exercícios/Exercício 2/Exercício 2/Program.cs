using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: um somente para números pares, 
             * e outro somente para números ímpares. 
             * Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.*/



            int[] vetorA = new int[10]; // new int[10] = {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}
            int[] vetorPar = new int[10];
            int[] vetorImpar = new int[10];

            //entrada
            for (int cont = 0; cont < 10; cont++)
            {
                Console.Write("Informe o " + (cont + 1).ToString() + "º valor: ");
                vetorA[cont] = int.Parse(Console.ReadLine());
            }

            //processamento
            int pares = 0, impares = 0;
            for (int cont = 0; cont < 10; cont++)
            {
                if (vetorA[cont] % 2 == 0)
                {
                    vetorPar[pares] = vetorA[cont];
                    pares++;
                }
                else
                {
                    vetorImpar[impares] = vetorA[cont];
                    impares++;
                }
            }

            Console.WriteLine();

            //saida
            for (int cont = 0; cont < impares; cont++)
            {
                Console.WriteLine("Valores impares: " + vetorImpar[cont]);
            }

            //saída
            //foreach (var impar in vetorImpar)
            //{
            //    if(impar != -1)
            //        Console.WriteLine("Valores impares: " + impar);
            //}

            for (int cont = 0; cont < pares; cont++)
            {
                Console.WriteLine("Valores pares: " + vetorPar[cont]);
            }
            Console.ReadKey();



        }
    }
}

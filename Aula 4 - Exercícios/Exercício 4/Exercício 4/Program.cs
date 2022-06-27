using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa que jogue pedra, papel e tesoura (Jokenpô) com você.
            Permitir que eu decida quantas rodadas iremos fazer;
            Ler a minha escolha (Pedra, papel ou tesoura);
            Decidir de forma aleatória a decisão do computador;
            Mostrar quantas rodadas cada jogador ganhou;
            Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um (computador e jogador);
            Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade de rodadas, se não finalize o programa.*/

            string resposta = "s";
            while (resposta != "n")
            {

                Console.WriteLine("Insira quantas rodadas você gostaria de jogar?");
                int rodadas = int.Parse(Console.ReadLine());
                //vitorias[0] - usuario; vitorias[1] - computador
                int[] vitorias = new int[2];
                //1 - pedra; 2 - papel; 3 - tesoura
                Random rnd = new Random();
                for (int i = 0; i < rodadas; i++)
                {
                    int opcaoComputador = rnd.Next(1, 3);
                    Console.WriteLine("Qual sua escolha da rodada?\n1 - Pedra\n2 - Papel\n3 - Tesoura");
                    int opcaoUsuario = int.Parse(Console.ReadLine());
                    // if(opcaoUsuario != 1 || opcaoUsuario != 2 || opcaoUsuario !=3){
                    //     Console.WriteLine("Opcão inválida, escolha de novo");
                    //     i--;
                    // };
                    if (opcaoComputador == 1)
                    {
                        if (opcaoUsuario == 2)
                        {
                            vitorias[0] += 1;
                        }
                        else if (opcaoUsuario == 3)
                        {
                            vitorias[1] += 1;
                        }
                    }
                    else if (opcaoComputador == 2)
                    {
                        if (opcaoUsuario == 3)
                        {
                            vitorias[0] += 1;
                        }
                        else if (opcaoUsuario == 1)
                        {
                            vitorias[1] += 1;
                        }
                    }
                    else if (opcaoComputador == 3)
                    {
                        if (opcaoUsuario == 1)
                        {
                            vitorias[0] += 1;
                        }
                        else if (opcaoUsuario == 2)
                        {
                            vitorias[1] += 1;
                        }
                    }
                    // Console.WriteLine(opcaoUsuario +" "+ opcaoComputador);
                    // Console.WriteLine(vitorias[0] +" "+ vitorias[1]);
                }
                if (vitorias[0] > vitorias[1])
                {
                    Console.WriteLine($"Você ganhou com {vitorias[0]} pontos contra {vitorias[1]} vitórias do computador");
                }
                else if (vitorias[0] < vitorias[1])
                {
                    Console.WriteLine($"O computador ganhou com {vitorias[1]} pontos contra {vitorias[0]} vitórias suas");
                }
                else
                {
                    Console.WriteLine("Deu empate!");
                }
                Console.WriteLine("Deseja jogar novamente?\n 's' para sim ou 'n' para não");
                resposta = Console.ReadLine();
            }
        }
    }
}

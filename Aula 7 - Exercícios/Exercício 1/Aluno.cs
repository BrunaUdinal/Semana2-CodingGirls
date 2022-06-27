using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    public class Aluno
    {
        private string nome;
        private double notaP1, notaP2;
        private double frequencia;


        public string Nome { get; set; }
        public double NotaP1 { get; set; }
        public double NotaP2 { get; set; }
        public double Frequencia { get; set; }


        public Aluno()
        {
            this.Nome = nome;
            this.NotaP1 = notaP1;
            this.NotaP2 = notaP2;
            this.Frequencia = frequencia;
            Cadastrar();
        }

        public void Cadastrar()
        {
            Console.WriteLine("Insira o nome do aluno(a): ");
            Nome = Console.ReadLine();
            Console.WriteLine("Insira a nota da prova 1: ");
            NotaP1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a nota da prova 2: ");
            NotaP2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a frequencia: ");
            Frequencia = double.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("Nota Prova 1: " + NotaP1);
            Console.WriteLine("Nota Prova 2: " + NotaP2);
            Console.WriteLine("Frequência: " + Frequencia);
        }

        //public void Consultar()
        //{
        //    Console.WriteLine("\nDigite o número do aluno (referente a ordem de cadastro): ");
        //    i = int.Parse(Console.ReadLine());
        //    i = +1;
        //    Imprimir();
        //}
    }
}

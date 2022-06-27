using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    public class Empregado
    {
        private string nome;
        private string cargo;
        private double salario;
        private double novoSalario;

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public double NovoSalario { get; set; }

        public Empregado()
        {
            Console.WriteLine("\nInsira o nome: ");
            Nome = Console.ReadLine();
            this.nome = Nome;

            Console.WriteLine("Insira o cargo: ");
            Cargo = Console.ReadLine();
            this.cargo = Cargo;

            Console.WriteLine("Insira o salario: ");
            Salario = Convert.ToDouble(Console.ReadLine());
            this.salario = Salario;

            this.novoSalario = NovoSalario;
        }
    }
}
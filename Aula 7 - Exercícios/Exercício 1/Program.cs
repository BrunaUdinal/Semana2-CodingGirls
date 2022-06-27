namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Considere uma classe Aluno. Esta classe possui como atributos privados o nome, as notas e a frequência. 
            Além do construtor, esta classe deve conter os métodos que cadastram os alunos, adiciona suas notas, 
            consulta um aluno por código e consulta todos os alunos do cadastro*/

            List<Aluno> lista = new List<Aluno>();
            lista.Add(new Aluno());
            lista.Add(new Aluno());


            Console.WriteLine($"\nDigite o código do aluno (referente a ordem de cadastro, começando por 0.): ");
            int i = int.Parse(Console.ReadLine());
            lista[i].Imprimir();

        }
    }
}
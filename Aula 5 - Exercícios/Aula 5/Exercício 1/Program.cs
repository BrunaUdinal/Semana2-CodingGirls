namespace Exercício_1
{
    internal class Program
    {       
            /*Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
            Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 
            2 notas de prova e 1 nota de trabalho.Escreva os seguintes métodos para esta classe:
            Calcular média: calcula e exibe a média final do aluno com base em suas notas;
            Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.*/

        static void Main(string[] args)
            {
                           
              Aluno aluno1 = new Aluno("45637", "Bruna", 7, 9, 8);
              aluno1.Media();

            }
        
    }
}

namespace Exercício_2
{
    internal class Program
    {
        /*Já criamos uma calculadora anteriormente, agora, vamos modificá-la aplicando os conceitos aprendidos até aqui.
         Crie uma classe calculadora.Esta classe deve ser abstrata e implementar as operações básicas 
        (soma, subtração, divisão e multiplicação).
        Utilizando o conceito de herança crie uma classe chamada calculadora científica que implementa os 
        seguintes cálculos: raiz quadrada e a potência.
        Utilize sobrecarga para aceitar valores inteiros e reais em seus cálculos.
        Dica: Utilize a biblioteca Math para facilitar seus cálculos.
        Na classe main você deve instanciar a calculadora e ao executar o programa, você deve ser capaz de selecionar a 
        operação desejada e inserir os valores a serem calculados*/
        
            static void Main(string[] args)
            {
                Calculadora calculadora = new Calculadora();
            }
        
    }
}
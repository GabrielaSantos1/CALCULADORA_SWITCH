// usa o System, que tem as principais classes usadas
using System;
//cria a classe Programa
class Programa
{
    //cria um principal para começar o programa
    static void Main()
    {

        //cria uma variável tipo char chamada 'op'
        char op;

        //cria uma variável tipo float chamada 'num1', já declarando seu valor inicial como 0;
        float num1 = 0;
        //cria uma variável tipo float chamada 'num2', já declarando seu valor inicial como 0;
        float num2 = 0;

        //fala para o user:
        Console.WriteLine("ENTRE COM O OPERADOR: +, -, *, / ");
        //guarda a resposta do usuário como valor da variável 'op'
        op = char.Parse(Console.ReadLine());

        //fala para o user:
        Console.WriteLine("ENTRE COM O VALOR 1: ");
        //guarda a resposta do usuário como valor da variável 'num1'
        num1 = float.Parse(Console.ReadLine());

        //fala para o user:
        Console.WriteLine("ENTRE COM O VALOR 2: ");
        //guarda a resposta do usuário como valor da variável 'num2'
        num2 = float.Parse(Console.ReadLine());

        //cria um switch (estrutura de troca) com o valor da variável 'op'
        switch (op){

            //caso o valor dado pelo user seja "+"
            case '+':

                //fala para o user que o valor da variável 'num1' + o valor da variável 'num1' é igual à soma das duas
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                
                //para este caso
                break;

            //caso o valor dado pelo user seja "+"
            case '-':

                //fala para o user que o valor da variável 'num1' - o valor da variável 'num1' é igual à subtração das duas
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                
                //para este caso
                break;

            //caso o valor dado pelo user seja "+"
            case '*':

                //fala para o user que o valor da variável 'num1' * o valor da variável 'num1' é igual à multiplicação das duas
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

                //para este caso
                break;

            //caso o valor dado pelo user seja "+"
            case '/':

                //fala para o user que o valor da variável 'num1' / o valor da variável 'num1' é igual à divisão das duas
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

                //para este caso
                break;

            //caso o valor dado pelo user não esteja em nenhum dos outros 4 casos acima
            default:

                //fala para o user:
                Console.Write("OPERADOR ERRADO, POR FAVOR INSIRA O OPERADOR CORRETO");

                //para este caso
                break;
        }
    }
}

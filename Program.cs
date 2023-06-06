using System;
class Programa
{
    static void Main()
    {

        char op;

        float num1 = 0;
        float num2 = 0;

        Console.WriteLine("ENTRE COM O OPERADOR: +, -, *, / ");
        op = char.Parse(Console.ReadLine());

        Console.WriteLine("ENTRE COM O VALOR 1: ");
        num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("ENTRE COM O VALOR 2: ");
        num2 = float.Parse(Console.ReadLine());

        switch (op){

            case '+':

                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");


                break;

            case '-':

                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

                break;

            case '*':

                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

                break;

            case '/':

                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

                break;

            default:

                Console.Write("OPERADOR ERRADO, POR FAVOR INSIRA O OPERADOR CORRETO");

                break;
        }
    }
}

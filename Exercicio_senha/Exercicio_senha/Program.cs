using System;

namespace Exercicio_senha
{
    class Program
    {
        static void Main(string[] args)

        //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha 
        //incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
        //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

        {
            Console.WriteLine("Digite a sua senha de 4 digitos: ");
            double pw = double.Parse (Console.ReadLine());

            while(pw != 2002) {
                Console.WriteLine("Senha inválida. Digite novamente por favor: ");
                pw = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta! Acesso liberado.");
            
        }
    }
}

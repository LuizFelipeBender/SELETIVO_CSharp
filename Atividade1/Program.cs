using System;

namespace Atividade1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Elabore um algoritmo para mostrar os números ímpares existentes em um intervalo.
            O usuário deverá fornecer os valores inicial (inicial > 0) e final (inicial < final) e os
            números ímpares existentes no intervalo ([inicial, final]) devem ser separados por um
            espaço em branco.
            valor de entrada:2 13
            Saída: 3 5 7 9 11 13
            */

            Console.WriteLine("Escreva o valor de inicial");
            int inicial = int.Parse(Console.ReadLine());//Esta linha recebe o valor da var inicial e faz a conversão para int
            Console.WriteLine("Escreva o valor de Final");
            int final = int.Parse(Console.ReadLine());//Esta linha recebe o valor da var final e faz a conversão para int
            for (int i = inicial; i <= final; i++) //Esta linha faz a validação para verificação se o mesmo é ímpar.
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"\n"+i);
                }
            }

        }
    }
}

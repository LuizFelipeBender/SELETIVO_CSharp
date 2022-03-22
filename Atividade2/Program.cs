using System;
namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.Write("Digite seu nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite seu endereco: ");
            p.Endereco = Console.ReadLine();
            Console.Write("Digite seu telefone: ");
            p.Telefone = Console.ReadLine();
            Console.Clear();
            p.EscreveDados();
            
        }
    }
}

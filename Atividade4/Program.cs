using Atividade3;
using System;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            Console.Write("Digite o número da conta: ");
            c.Numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o títular da conta: ");
            c.Titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            c.Saldo = Convert.ToDouble(Console.ReadLine());


            c.Rendimento();
            cc.RendimentoCorrente(c);
            cp.RendimentoPoupanca(c);
            Imposto im = new Imposto();
            im.EscreveImposto();

        }
    }
}

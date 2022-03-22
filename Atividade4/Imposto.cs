using Atividade3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Imposto
    {
        public double Impostocorrente { get; set; }
        public double ImpostoPoupanca{ get; set; }
        public void CalcularImposto()
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            this.Impostocorrente = cc.ValorCorrente * 0.25;
            this.ImpostoPoupanca = cp.ValorPoupanca * 0.10;
        }

        public void EscreveImposto()
        {
            Console.Write($"Imposto do rendimento corrente: {Impostocorrente} ");
            Console.Write($"Imposto do rendimento poupança: {ImpostoPoupanca}");
        }
    }
}

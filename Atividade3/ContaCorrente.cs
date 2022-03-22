using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente() : base()
        {
            this.ValorCorrente = 0;
        }
        public ContaCorrente(int numero, String titular, double saldo, double valorCorrente) : base(numero, titular, saldo)
        {
            this.ValorCorrente = valorCorrente;
        }
        public double ValorCorrente { get; set; }

        public void RendimentoCorrente(Conta c)
        {
            this.ValorCorrente = (c.Saldo * 0.03);

            Console.WriteLine($"Rendimento conta corrente: {ValorCorrente}");
        }
    }
}

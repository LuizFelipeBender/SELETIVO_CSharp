using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    public class Conta
    {
        public Conta()
        {
            this.Numero = 0;
            this.Titular = "";
            this.Saldo = 0;
        }

        public Conta(int numero, String titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public int Numero { get; set; }
        public String Titular { get; set; }
        public double Saldo { get; set; }
        
        public void Rendimento()
        {
            Console.WriteLine($"rendimento: {Saldo}");
        }
    }
}

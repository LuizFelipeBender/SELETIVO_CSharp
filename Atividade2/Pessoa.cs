using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Nome = "";
            this.Endereco = "";
            this.Telefone = "";
        }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public void EscreveDados()
        {
            Console.WriteLine($"Nome: {Nome}" );
            Console.WriteLine($"Endereço: {Endereco}" );
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}

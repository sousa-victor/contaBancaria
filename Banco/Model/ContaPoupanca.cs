using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ContaPoupanca : Conta
    {
        private int aniversario;

        public ContaPoupanca(int numero, int agencia, int tipo, string titular, decimal saldo, int aniversario) : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }

        public int GetAniversario()
        {
            return this.aniversario;
        }

        public void SetAniversario(int aniversario) {
            this.aniversario = aniversario;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Aniversário da conta: {this.aniversario}");
        }

    }
}

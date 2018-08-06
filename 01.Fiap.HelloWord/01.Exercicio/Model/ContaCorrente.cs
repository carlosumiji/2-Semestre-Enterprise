
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta, IContaInvestimento
    {
        TipoConta TipoConta;

        public void CalculaRetornoInvestimento()
        {
            throw new NotImplementedException();
        }

        public override void Depositar(decimal valor)
        {
            Saldo = valor;
        }

        public override void Retirar(decimal valor)
        {
            if (TipoConta == TipoConta.Comum && Saldo < 0) {

                throw new Exception("Saldo Negativo");
            }
        }
    }
}

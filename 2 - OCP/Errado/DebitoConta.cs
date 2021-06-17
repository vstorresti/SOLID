using System;

namespace Errado
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                //Debita da conta corrente
            }

            if(tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversario da Conta
                // Debita da conta poupança
            }
        }
    }
}

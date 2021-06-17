using System;

namespace Correto2
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negocio para debito em conta investimento
            return debitoConta.FormatarTransacao();
        }
    }
}

using System;

namespace Correto2
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Logica de negocio para debito em conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}

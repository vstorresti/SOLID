using System;

namespace Correto2
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Logica de negocio para debito em conta Poupanca
            return debitoConta.FormatarTransacao();
        }
    }
}

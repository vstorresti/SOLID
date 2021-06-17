namespace Correto1
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita Conta Corrente
            return FormatarTransacao();
        }
        
    }
}
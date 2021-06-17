using System;
using System.Linq;

namespace Correto1
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao {get; set;}
        public abstract string Debitar(decimal valor, string conta);

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXZ1234567890";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return NumeroTransacao;
        }
    }
}

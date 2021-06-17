using System;
using System.Linq;

namespace Correto2
{
    public class DebitoConta
    {
        public string NumeroConta {get; set;}
        public string NumeroTransacao {get; set;}
        public decimal Valor {get; set;}

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

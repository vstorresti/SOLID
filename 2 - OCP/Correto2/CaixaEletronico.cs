using System;

namespace Correto2
{
    public class CaixaEletronico
    {
        public static void Operacoes()
        {
            MenuOperacoes();

            var opcao = Console.ReadKey();
            var retorno = string.Empty;

            var debitoConta = DadosDebito();

            switch(opcao.KeyChar)
            {
                case '1':
                    System.Console.WriteLine("Efetuando operação em conta corrente");;
                    retorno = debitoConta.DebitarContaCorrente();
                    break;
                case '2':
                    System.Console.WriteLine("Efetuando operação em conta poupanca");;
                    retorno = debitoConta.DebitarContaPoupanca();
                    break;
                case '3':
                    System.Console.WriteLine("Efetuando operação em conta investimento");;
                    retorno = debitoConta.DebitarContaInvestimento();
                    break;
            }

            RetornoTransacao(retorno);
        }

        private static void MenuOperacoes()
        {
            Console.Clear();
            Console.WriteLine("Caixa Eletronico SOLID");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Saque conta corrente");
            Console.WriteLine("1 - Saque conta poupanca");
            Console.WriteLine("1 - Saque conta investimento");
        }

        private static DebitoConta DadosDebito()
        {
            Console.WriteLine();
            Console.WriteLine("................");
            Console.WriteLine();
            Console.WriteLine("Digite a conta");
            var conta = Console.ReadLine();
            Console.WriteLine("Digite o valor");
            var valor = Convert.ToDecimal(Console.ReadLine());

            var debitoConta = new DebitoConta()
            {
                NumeroConta = conta,
                Valor = valor
            };

            return debitoConta;
        }

        private static void RetornoTransacao(string retorno)
        {
            Console.WriteLine();
            Console.WriteLine("Sucesso! Transacao: " + retorno);
            Console.ReadKey();
        }
    }
}
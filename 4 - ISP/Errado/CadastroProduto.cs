using System;

namespace Errado
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            //Valida registros do Produto
        }

        public void SalvarBanco()
        {
            //Salva os Registros
        }

        public void EnviarEmail()
        {
            throw new NotImplementedException("Produto não possui um email");
        }
    }
}
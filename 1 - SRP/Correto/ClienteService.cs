namespace Correto
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if(!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("email@email.com", cliente.Email.Endereco, "Bem Vindo", "Essa é a Mensagem");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
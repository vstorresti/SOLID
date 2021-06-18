using Correto.Interfaces;

namespace Correto
{
    public class ClienteService : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteService(
            IClienteRepository clienteRepository,
            IEmailServices emailServices
        )
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }
        
        public string AdicionarCliente(Cliente cliente)
        {
            if(!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("email@email.com", cliente.Email.Endereco, "Bem Vindo", "Essa é a Mensagem");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
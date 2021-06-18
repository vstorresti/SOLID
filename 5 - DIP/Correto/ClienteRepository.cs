using System.Data;
using System.Data.SqlClient;
using Correto.Interfaces;

namespace Correto
{
    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using(var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue(parameterName:"nome", cliente.Nome);
                cmd.Parameters.AddWithValue(parameterName:"email", cliente.Email);
                cmd.Parameters.AddWithValue(parameterName:"cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue(parameterName:"datacadastro", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Errado
{
    public class Cliente
    {
        public int ClienteId {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string CPF {get; set;}
        public DateTime DataCadastro {get;set;}

        public string AdicionarCliente()
        {
            if(!Email.Contains(value:"@"))
                return "Cliente com e-mail inválido";
            
            if(CPF.Length != 11)
                return "Cliente com CPF inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue(parameterName:"nome", Nome);
                cmd.Parameters.AddWithValue(parameterName:"email", Email);
                cmd.Parameters.AddWithValue(parameterName:"cpf", CPF);
                cmd.Parameters.AddWithValue(parameterName:"datacadastro", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("email@email.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo";
            mail.Body = "Você foi cadastrado com sucesso!";
            client.Send(mail);

            return "Cliente cadastrado com sucesso";
        }

    }
}

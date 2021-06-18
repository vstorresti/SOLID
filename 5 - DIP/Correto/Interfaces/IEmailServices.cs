namespace Correto.Interfaces
{
    public interface IEmailServices
    {
         void Enviar(string de, string para, string assunto, string mensagem);
    }
}
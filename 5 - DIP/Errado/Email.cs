namespace Errado
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Endereco.Contains(value:"@");
        }
    }
}
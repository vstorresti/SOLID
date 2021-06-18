namespace Errado
{
    public class CPF
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 11;
        }
        
    }
}
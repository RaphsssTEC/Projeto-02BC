namespace Projeto02BC
{
    public class PessoaFisica : Cliente
    {
        public string CPF
        {
            get { return CPF; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ñão foi possivel definir o CPF.");
                    return;
                }

                CPF = value;
            }
        }

        public override void exibirDocumento()
        {
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}

namespace Projeto02BC.Entidades.Pessoa
{
    public class PessoaFisica : Cliente
    {
        public string CPF
        {
            get { return CPF; }
            set
            {
                if (string.IsNullOrEmpty(value))
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

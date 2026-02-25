namespace Projeto02BC
{
    public abstract class Cliente
    {
        public string nome { get; set; }
        public string endereço { get; set; }
        public string email { get; set; }

        public abstract void exibirDocumento();
    }
}

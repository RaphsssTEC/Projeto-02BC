using Projeto02BC;

namespace Proj02
{
    public abstract class ContaBancaria
    {
        public Cliente titular { get; set; }
        public string agencia { get; set; }
        public string numeroConta { get; set; }
        public decimal saldo
        {
            get { return saldo; }
            protected set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Não foi possivel atribuir o saldo.");
                    return;
                }

                this.saldo = value;
                return;
            }
        }

        public abstract void calcularTarifa();
    }
}
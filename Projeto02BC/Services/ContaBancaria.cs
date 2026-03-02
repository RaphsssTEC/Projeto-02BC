using Projeto02BC.Entidades;

namespace Projeto02BC.Services
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

                saldo = value;
                return;
            }
        }

        public abstract void calcularTarifa();
    }
}
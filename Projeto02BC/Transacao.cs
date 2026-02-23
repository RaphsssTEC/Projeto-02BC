using Proj02;

namespace Projeto02BC
{
    public class Transacao
    {
        public ContaBancaria contaOrigem { get; set; }
        public ContaBancaria contaDestino { get; set; }
        public DateTime data { get; set; }
        public string tipo { get; set; }
        protected decimal _valor { get; set; }
        public decimal valor
        {
            get { return _valor; }
            set { if (value > 0) _valor = value; }
        }

        public virtual bool validar()
        {
            return _valor > 0;
        }
    }
}
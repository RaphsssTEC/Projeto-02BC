using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj02
{
    public class ContaBancaria
    {
        public string agencia { get; set; }
        public string numeroConta { get; set; }
        public decimal saldo { get; private set; }

        public void setSaldo(decimal valor) 
        {
            if (valor >= 0)
            {
                this.saldo = valor;
                return;
            }

            Console.WriteLine("Não foi possivel atribuir o saldo.");
            return;
        }
    }
}
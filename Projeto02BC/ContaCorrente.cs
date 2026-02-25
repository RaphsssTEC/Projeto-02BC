using Proj02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02BC
{
    public class ContaCorrente : ContaBancaria
    {
        public override void calcularTarifa() => saldo -= 15.00m;
    }
}

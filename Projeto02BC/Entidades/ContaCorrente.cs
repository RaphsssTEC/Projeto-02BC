using Projeto02BC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02BC.Entidades
{
    public class ContaCorrente : ContaBancaria
    {
        public override void calcularTarifa() => saldo -= 15.00m;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02BC
{
    class TransacaoTed : Transacao
    {
        public override bool validar()
        {
            return base.validar() && _valor > 5000;
        }
    }
}

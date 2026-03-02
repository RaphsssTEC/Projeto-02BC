using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02BC.Services
{
    public interface IConversorGrandeza
    {
        decimal converter(decimal valor);
        string getSimbolo();
    }
}

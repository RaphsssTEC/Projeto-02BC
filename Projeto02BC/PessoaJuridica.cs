using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02BC
{
    public class PessoaJuridica : Cliente
    {
        public string CNPJ
        {
            get { return CNPJ; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ñão foi possivel definir o CNPJ.");
                    return;
                }

                CNPJ = value;
            }
        }

        public string razaoSocial { get; set; }

        public override void exibirDocumento()
        {
            Console.WriteLine($"CNPJ: {CNPJ}");
        }
    }
}

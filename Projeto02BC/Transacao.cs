using Proj02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02BC
{
    public class Transacao
    {
        public ContaBancaria contaOrigem { get; set; }
        public ContaBancaria contaDestino { get; set; }
        public DateTime data { get; set; }
        public string tipo { get; set; }
        private decimal _valor { get; set; }
        public decimal valor
        {
            get { return _valor; }

            set
            {
                if (value > 0)
                {
                    _valor = value;
                }
                else
                {
                    Console.WriteLine("ERRO: Valor da transação deve ser positivo!");
                }
            }
        }
    }

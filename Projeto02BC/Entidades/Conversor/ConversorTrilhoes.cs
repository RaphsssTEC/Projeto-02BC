using Projeto02BC.Services;

namespace Projeto02BC.Entidades.Conversor
{
    public class ConversorTrilhoes : IConversorGrandeza
    {
        public decimal converter(decimal valor)
        {
            return valor / 1000000000000m;
        }


        public string getSimbolo()
        {
            return "Tri";
        }
    }
}

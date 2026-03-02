namespace Projeto02BC.Entidades
{
    public class Banco
    {
        public string nome { get; set; }
        private string _codigoBacen { get; set; }
        public string codigoBacen
        {
            get { return _codigoBacen; }
            set
            {
                // TODO: Validar o código do Bacen
                _codigoBacen = value;
            }
        }
    }
}

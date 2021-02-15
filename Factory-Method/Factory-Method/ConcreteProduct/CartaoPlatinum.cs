using Factory_Method.Product;

namespace Factory_Method.ConcreteProduct
{
    public class CartaoPlatinum : CartaoCredito
    {
        private string _tipoCartao { get; set; }
        private int _limiteCredito { get; set; }
        private int _cobrancaAnual { get; set; }

        public CartaoPlatinum(int limiteCredito, int cobrancaAnual)
        {
            _tipoCartao = "Platinum";
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }

        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }

        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}

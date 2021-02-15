using Factory_Method.ConcreteProduct;
using Factory_Method.Creator;
using Factory_Method.Product;

namespace Factory_Method.ConcreteCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public PlatinumFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
        }
    }
}

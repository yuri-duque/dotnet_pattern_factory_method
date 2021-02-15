using Factory_Method.Product;

namespace Factory_Method.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}

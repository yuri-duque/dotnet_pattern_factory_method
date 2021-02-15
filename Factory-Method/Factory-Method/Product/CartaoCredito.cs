namespace Factory_Method.Product
{
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get; }
        public abstract int LimiteCredito { get; set; }
        public abstract int CobrancaAnual { get; set; }
    }
}

using Factory_Method.ConcreteCreator;
using Factory_Method.Creator;
using Factory_Method.Product;
using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;
            Console.WriteLine("Digite o tipo de cartão que gostaria de obter:");
            string tipoCartao = Console.ReadLine();

            switch (tipoCartao)
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "Platinum":
                    cartaoFactory = new PlatinumFactory(100000, 500);
                    break;
                case "Titanium":
                    cartaoFactory = new BlackFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();

            Console.WriteLine("\nOs detalhes do seu cartão estão abaixo:\n");

            Console.WriteLine($"Tipo: {cartaoCredito.TipoCartao}");
            Console.WriteLine($"Limite Credito: {cartaoCredito.LimiteCredito}");
            Console.WriteLine($"Cobranca Anual: {cartaoCredito.CobrancaAnual}");

            Console.ReadKey();
        }
    }
}

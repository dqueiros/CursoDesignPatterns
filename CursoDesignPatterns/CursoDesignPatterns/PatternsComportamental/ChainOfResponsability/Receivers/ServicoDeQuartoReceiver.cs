
using CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel;

namespace CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers
{
    public class ServicoDeQuartoReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServicos(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança taxa do serviços de quarto...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.03);

            return base.ExecutarCobrancaServicos(checkout);
        }
    }
}

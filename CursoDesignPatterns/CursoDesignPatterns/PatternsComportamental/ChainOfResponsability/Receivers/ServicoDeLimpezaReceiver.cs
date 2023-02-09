
using CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel;

namespace CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers
{
    public class ServicoDeLimpezaReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServicos(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança taxa dos serviços de limpeza...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.025);

            return base.ExecutarCobrancaServicos(checkout);
        }
    }
}

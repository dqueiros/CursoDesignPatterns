
using CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel;

namespace CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers
{
    public class ServicoDeLavanderiaReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServicos(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança taxa dos serviços de Lavanderia...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.028);
            
            return base.ExecutarCobrancaServicos(checkout);
        }
    }
}

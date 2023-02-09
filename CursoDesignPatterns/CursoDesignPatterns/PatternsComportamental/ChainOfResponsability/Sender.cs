
using CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers;

namespace CursoDesignPatterns.PatternsComportamental.ChainOfResponsability
{
    public class Sender
    {
        public void RealizarCheckout()
        {
            Checkout checkout = new Checkout(1001, 20, 23.50);

            Console.WriteLine($"\nAntes\nValor total checkout: {checkout.ValorTotal.ToString("C")}");
            Console.WriteLine(new String('-', 40));

            var deLavanderia = new ServicoDeLavanderiaReceiver();
            var deQuarto = new ServicoDeQuartoReceiver();
            var deLimpeza = new ServicoDeLimpezaReceiver();

            deLavanderia.AddNext(deQuarto);
            deQuarto.AddNext(deLimpeza);

            deLavanderia.ExecutarCobrancaServicos(checkout);

            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"\nDepois\nValor total checkout: {checkout.ValorTotal.ToString("C")}");  
        }
    }
}

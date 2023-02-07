using CursoDesignPatterns.PatternsEstrutural.Decorator.Decorators;
using CursoDesignPatterns.PatternsEstrutural.Decorator.Interfaces;
using CursoDesignPatterns.PatternsEstrutural.Decorator.Servicos;

namespace CursoDesignPatterns.PatternsEstrutural.Decorator
{
    public class Client
    {
        public void Consumir()
        {
            IPet banhoTosa = new BanhoTosa("Banho e Tosa", 45.00);

            IPet acessorioDecorator = new AcessorioDecorator(banhoTosa);
            IPet luxoSpaDecorator = new LuxoSpaDecorator(acessorioDecorator);

            Console.WriteLine("Resumo dos serviços Pet Shop");
            Console.WriteLine(luxoSpaDecorator.GetNomeServico());
            Console.WriteLine("Valor total: " + luxoSpaDecorator.GetValorServico());
        }
    }
}

using CursoDesignPatterns.PatternsEstrutural.Decorator.Interfaces;

namespace CursoDesignPatterns.PatternsEstrutural.Decorator.Decorators
{
    public class AcessorioDecorator : PetDecorator
    {
        public AcessorioDecorator(IPet pet) : base(pet)
        {
        }

        public override string GetNomeServico()
        {
            return _pet.GetNomeServico() + "\n[+] Acessório";
        }

        public override double GetValorServico()
        {
            return _pet.GetValorServico() + 30.00;
        }
    }
}

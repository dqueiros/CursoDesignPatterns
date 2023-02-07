using CursoDesignPatterns.PatternsEstrutural.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsEstrutural.Decorator.Decorators
{
    public class LuxoSpaDecorator : PetDecorator
    {
        public LuxoSpaDecorator(IPet pet) : base(pet)
        {
        }

        public override string GetNomeServico()
        {
            return _pet.GetNomeServico() + "\n[+] Luxo SPA";
        }

        public override double GetValorServico()
        {
            return _pet.GetValorServico() + 200.00;
        }
    }
}

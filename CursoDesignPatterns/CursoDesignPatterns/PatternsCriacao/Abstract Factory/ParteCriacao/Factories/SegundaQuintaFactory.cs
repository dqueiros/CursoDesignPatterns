using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Interfaces;
using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Segunda e Quinta Criada");
            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}

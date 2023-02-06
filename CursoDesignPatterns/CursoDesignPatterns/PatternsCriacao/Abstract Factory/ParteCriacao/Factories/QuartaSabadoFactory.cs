 using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Interfaces;
using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Factories
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Quarta e Sabado Criada");
            DietaQuartaSabado dieta = new DietaQuartaSabado();
            TreinoQuartaSabado treino = new TreinoQuartaSabado();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}

using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Interfaces;
using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Terça e Sexta Criada");
            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}

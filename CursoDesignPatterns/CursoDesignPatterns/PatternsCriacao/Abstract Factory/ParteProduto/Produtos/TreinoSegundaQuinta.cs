using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos
{
    public class TreinoSegundaQuinta : ITreino
    {
        public TreinoSegundaQuinta()
        {
            this.ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino de Segunda e Quinta Feira. . .");
        }
    }
}

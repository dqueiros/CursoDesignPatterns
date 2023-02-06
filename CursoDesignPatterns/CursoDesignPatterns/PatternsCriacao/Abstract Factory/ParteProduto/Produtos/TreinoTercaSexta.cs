using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos
{
    public class TreinoTercaSexta : ITreino
    {
        public TreinoTercaSexta()
        {
            this.ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino de Terça e Sexta Feira. . .");
        }
    }
}

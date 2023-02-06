using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos
{
    public class DietaQuartaSabado : IDieta
    {
        public DietaQuartaSabado()
        {
            this.ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Quarta e Sábado. . .");
        }
    }
}

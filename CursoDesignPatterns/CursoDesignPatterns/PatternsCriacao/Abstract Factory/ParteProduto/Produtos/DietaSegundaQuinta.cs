using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos
{
    public class DietaSegundaQuinta : IDieta
    {
        public DietaSegundaQuinta()
        {
            this.ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Segunda e Quinta Feira. . .");
        }
    }
}

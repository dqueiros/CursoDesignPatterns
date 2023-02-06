using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteProduto.Produtos
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta()
        {
            this.ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Terça e Sexta Feira. . .");
        }
    }
}

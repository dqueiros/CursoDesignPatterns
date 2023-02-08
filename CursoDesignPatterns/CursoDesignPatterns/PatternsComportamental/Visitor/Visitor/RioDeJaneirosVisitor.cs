
using CursoDesignPatterns.PatternsComportamental.Visitor.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Visitor.Produtos;

namespace CursoDesignPatterns.PatternsComportamental.Visitor.Visitor
{
    public class RioDeJaneirosVisitor : IVisitor
    {
        public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.Peso / 100) + 5;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }

        public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.Peso / 100) + 10;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }
    }
}

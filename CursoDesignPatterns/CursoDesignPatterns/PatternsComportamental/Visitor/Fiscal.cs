
using CursoDesignPatterns.PatternsComportamental.Visitor.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Visitor.Produtos;
using CursoDesignPatterns.PatternsComportamental.Visitor.Visitor;

namespace CursoDesignPatterns.PatternsComportamental.Visitor
{
    public class Fiscal
    {
        public void CalcularImpostos()
        {
            CalcularProdutosPereciveis();
            Console.WriteLine(new String('-',40));
            CalcularProdutosNaoPereciveis();
        }
        private static void CalcularProdutosNaoPereciveis()
        {
            List<ProdutoNaoPerecivel> produtoNaoPereciveis = new List<ProdutoNaoPerecivel>()
            {
                new ProdutoNaoPerecivel("Antena wifi", 500),
                new ProdutoNaoPerecivel("Perfume Francês", 1000)
            };

            Console.WriteLine("\nCalculado imposto produtos Não perecíveis");

            foreach (var pnp in produtoNaoPereciveis)
            {
                Console.WriteLine($"produto: {pnp.Nome}\nPeso: {pnp.Peso}");

                foreach (var visitor in GetVisitors())
                {
                    visitor.CalcularImpostoProdutoNaoPerecivel(pnp);
                }

                Console.WriteLine();
            }
        }

        private static void CalcularProdutosPereciveis()
        {
            List<ProdutoPerecivel> produtoPereciveis = new List<ProdutoPerecivel>()
            {
                new ProdutoPerecivel("Especiarias", 2500),
                new ProdutoPerecivel("Polpas de frutas", 2000)
            };

            Console.WriteLine("\nCalculado imposto produtos perecíveis");

            foreach (var pp in produtoPereciveis)
            {
                Console.WriteLine($"produto: {pp.Nome}\nPeso: {pp.Peso}");

                foreach (var visitor in GetVisitors())
                {
                    visitor.CalcularImpostoProdutoPerecivel(pp);
                }

                Console.WriteLine();
            }
        }

        private static List<IVisitor> GetVisitors() => new List<IVisitor>()
        {
            new RioDeJaneirosVisitor(),
            new SaoPauloVisitor()
        }; 
    }
}

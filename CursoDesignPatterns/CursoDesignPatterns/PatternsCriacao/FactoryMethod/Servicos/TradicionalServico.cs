using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.FactoryMethod.Servicos
{
    public class TradicionalServico : IServico
    {
        public TradicionalServico()
        {
            Console.WriteLine("Produto Tradicional criado com sucesso!");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica de cobrança de serviços para Tradicional
        }
    }
}

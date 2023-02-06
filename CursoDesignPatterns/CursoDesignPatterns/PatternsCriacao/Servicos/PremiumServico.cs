using CursoDesignPatterns.PatternsCriacao.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Servicos
{
    public class PremiumServico : IServico
    {
        public PremiumServico()
        {
            Console.WriteLine("Produto Premium criado com sucesso!");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica de cobrança de serviços para Premium
        }
    }
}

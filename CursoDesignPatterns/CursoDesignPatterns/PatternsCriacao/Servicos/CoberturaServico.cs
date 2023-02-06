using CursoDesignPatterns.PatternsCriacao.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Servicos
{
    public class CoberturaServico : IServico
    {
        public CoberturaServico()
        {
            Console.WriteLine("Produto Cobertura criado com sucesso!");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica de cobrança de serviços para Cobertura
        }
    }
}

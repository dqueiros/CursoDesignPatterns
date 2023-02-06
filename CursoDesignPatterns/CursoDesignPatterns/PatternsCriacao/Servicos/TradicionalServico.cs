using CursoDesignPatterns.PatternsCriacao.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Servicos
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

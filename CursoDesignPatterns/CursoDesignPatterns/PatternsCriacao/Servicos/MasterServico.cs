using CursoDesignPatterns.PatternsCriacao.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.Servicos
{
    public class MasterServico : IServico
    {
        public MasterServico()
        {
            Console.WriteLine("Produto Master criado com sucesso!");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica de cobrança de serviços para Master
        }
    }
}

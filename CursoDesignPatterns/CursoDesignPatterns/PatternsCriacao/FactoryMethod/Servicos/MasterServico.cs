using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.FactoryMethod.Servicos
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

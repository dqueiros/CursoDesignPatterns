using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Enums;
using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;
using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Servicos;

namespace CursoDesignPatterns.PatternsCriacao.FactoryMethod
{
    public class SelecionaServico : ServicoFactory
    {
        public override IServico Fabricarproduto(eTiposServicos tiposServicos)
        {
            switch (tiposServicos)
            {
                case eTiposServicos.tradicional:
                    return new TradicionalServico();
                case eTiposServicos.premium:
                    return new PremiumServico();
                case eTiposServicos.master:
                    return new MasterServico();
                case eTiposServicos.cobertura:
                    return new CoberturaServico();
                default:
                    return null;
            }
        }
    }
}

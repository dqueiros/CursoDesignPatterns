using CursoDesignPatterns.PatternsCriacao.Enums;
using CursoDesignPatterns.PatternsCriacao.Interfaces;
using CursoDesignPatterns.PatternsCriacao.Servicos;

namespace CursoDesignPatterns.PatternsCriacao
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

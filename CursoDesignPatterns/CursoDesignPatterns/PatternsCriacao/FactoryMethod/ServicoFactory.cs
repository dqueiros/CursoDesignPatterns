using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Enums;
using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico Fabricarproduto(eTiposServicos tiposServicos);
    }
}

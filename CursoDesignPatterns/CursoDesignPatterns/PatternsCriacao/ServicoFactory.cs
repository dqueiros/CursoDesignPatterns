using CursoDesignPatterns.PatternsCriacao.Enums;
using CursoDesignPatterns.PatternsCriacao.Interfaces;

namespace CursoDesignPatterns.PatternsCriacao
{
    public abstract class ServicoFactory
    {
        public abstract IServico Fabricarproduto(eTiposServicos tiposServicos);
    }
}

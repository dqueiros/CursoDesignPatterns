
using CursoDesignPatterns.PatternsEstrutural.Bridge.Implementacao.Interface;

namespace CursoDesignPatterns.PatternsEstrutural.Bridge.Abstracao.Interface
{
    public interface IMaterial
    {
        public ICor CorImplementacao { get; set; }
        string ConsultaNoEstoque();
    }
}

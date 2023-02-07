using CursoDesignPatterns.PatternsEstrutural.Bridge.Abstracao.Interface;
using CursoDesignPatterns.PatternsEstrutural.Bridge.Implementacao.Interface;

namespace CursoDesignPatterns.PatternsEstrutural.Bridge.Abstracao
{
    public class PincelMarcador : IMaterial
    {
        public ICor CorImplementacao { get; set; }

        public string ConsultaNoEstoque()
        {
            return this.CorImplementacao.ConsultarQuantidadePorCor("Pincel Marcador");
        }
    }
}

using CursoDesignPatterns.PatternsEstrutural.Adapter.Interfaces;

namespace CursoDesignPatterns.PatternsEstrutural.Adapter
{
    public class Adapter : IAdapter
    {
        BusinessLegado legado;

        public Adapter(BusinessLegado legado)
        {
            this.legado = legado;
        }

        public string ExecutarRotinaContasPagar(string mes)
        {
            return legado.ExecutarRotinasContasPagar(mes);
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            return legado.ExecutarRotinasContasReceber(mes);
        }
    }
}

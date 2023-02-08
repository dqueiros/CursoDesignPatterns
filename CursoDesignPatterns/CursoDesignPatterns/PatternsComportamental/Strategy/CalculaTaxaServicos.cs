using CursoDesignPatterns.PatternsComportamental.Strategy.Interfaces;

namespace CursoDesignPatterns.PatternsComportamental.Strategy
{
    public class CalculaTaxaServicos
    {
        public void Calcular(List<IServico> servicos)
        {
            foreach (var servico in servicos)
            {
                servico.CalcularServico();
                Console.WriteLine(new String('-',40));
            }
        }
    }
}

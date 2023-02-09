using CursoDesignPatterns.PatternsComportamental.State.Interfaces;

namespace CursoDesignPatterns.PatternsComportamental.State.Estados
{
    public class EstadoA : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do Estado A");
            context.Estado = new EstadoB();
        }
    }
}

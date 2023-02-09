using CursoDesignPatterns.PatternsComportamental.State.Interfaces;

namespace CursoDesignPatterns.PatternsComportamental.State.Estados
{
    public class EstadoB : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do Estado B");
            context.Estado = new EstadoA();
        }
    }
}

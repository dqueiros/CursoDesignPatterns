
using CursoDesignPatterns.PatternsComportamental.State.Estados;

namespace CursoDesignPatterns.PatternsComportamental.State
{
    public class Client
    {
        public void ExecutarContext()
        {
            Context context = new Context(new EstadoA());

            context.Trocar();
            context.Trocar();
        }
    }
}

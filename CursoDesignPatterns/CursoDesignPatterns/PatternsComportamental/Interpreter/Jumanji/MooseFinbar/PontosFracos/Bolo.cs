
namespace CursoDesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos
{
    public class Bolo : IPontoFraco
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[-] - Alérgia mortal a Bolo\n";
        }
    }
}

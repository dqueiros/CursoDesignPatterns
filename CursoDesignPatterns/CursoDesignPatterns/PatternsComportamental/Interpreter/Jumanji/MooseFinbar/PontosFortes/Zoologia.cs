
namespace CursoDesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes
{
    public class Zoologia : IPontoForte
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[+] - Expert em Zoologia\n";
        }
    }
}
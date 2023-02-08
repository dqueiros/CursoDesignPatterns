
namespace CursoDesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes
{
    public class Armeiro : IPontoForte
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "[+] - Manuseio de Arma\n";
        }
    }
}

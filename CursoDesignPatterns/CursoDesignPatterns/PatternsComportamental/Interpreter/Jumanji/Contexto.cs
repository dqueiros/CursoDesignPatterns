
namespace CursoDesignPatterns.PatternsComportamental.Interpreter.Jumanji
{
    public class Contexto
    {
        public Contexto(string personagem)
        {
            Personagem = personagem;
            this.Conteudo = string.Empty;
        }

        public string Personagem { get; set; }
        public string Conteudo { get; set; }
    }
}

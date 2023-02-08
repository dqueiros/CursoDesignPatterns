
using CursoDesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using CursoDesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos;

namespace CursoDesignPatterns.PatternsComportamental.Interpreter.Jumanji
{
    public class ApresentaPopup
    {
        public void ApresentarHabilidadesPopup()
        {
            List<IPontoForte> pontosFortes = new List<IPontoForte>() 
            {
                new Armeiro(),
                new Zoologia()
            };

            List<IPontoFraco> pontosFracos = new List<IPontoFraco>()
            {
                new Bolo(),
                new Forca(),
                new Velocidade()
            };

            var mooseFinbar = new Contexto("Moose Finbar");

            Habilidades habilidades = new Habilidades(pontosFortes, pontosFracos);
            habilidades.Interpretar(mooseFinbar);
        }
    }
}

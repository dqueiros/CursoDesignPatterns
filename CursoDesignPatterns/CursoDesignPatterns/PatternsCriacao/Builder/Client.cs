
using CursoDesignPatterns.PatternsCriacao.Builder.Builders;
using CursoDesignPatterns.PatternsCriacao.Builder.Studios;
using System.Xml;

namespace CursoDesignPatterns.PatternsCriacao.Builder
{
    public class Client
    {
        public void ConsumirDadosStudio()
        {
            Director director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;
            
            studioBuilder = new Studio24mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "24m²");

            studioBuilder = new Studio26mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "26m²");

            studioBuilder = new Studio28mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "28m²");
        }

        private void ImprimirResultado(Studio studio, string nome)
        {
            Console.WriteLine(new String('-',40));
            Console.WriteLine($"[+] - Studio {nome}");
            Console.WriteLine("Valor: {0}\nPiso: {1}\rFinanciamento: {2}", studio.ValorStudio.ToString("C"), 
                studio.TipoPiso, 
                studio.TipoFinanciamento);
        }
    }
}

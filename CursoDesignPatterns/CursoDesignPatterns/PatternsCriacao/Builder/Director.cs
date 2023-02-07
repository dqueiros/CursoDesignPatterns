using CursoDesignPatterns.PatternsCriacao.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsCriacao.Builder
{
    public class Director
    {
        public void ConstruirStudio(StudioBuilder studioBuilder)
        {
            studioBuilder.EscolherPiso();
            studioBuilder.DefinirValorStudio();
            studioBuilder.EscolherFinanciamento();
        }
    }
}

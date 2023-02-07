using CursoDesignPatterns.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsCriacao.Builder.Builders
{
    public abstract class StudioBuilder
    {
        protected Studio studio;

        public Studio GetStudio()
        {
            return studio;
        }

        public abstract void EscolherPiso();
        public abstract void EscolherFinanciamento();
        public abstract void DefinirValorStudio();
    }
}

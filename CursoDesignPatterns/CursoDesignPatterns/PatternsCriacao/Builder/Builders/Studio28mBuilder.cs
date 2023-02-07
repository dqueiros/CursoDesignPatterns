using CursoDesignPatterns.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsCriacao.Builder.Builders
{
    public class Studio28mBuilder : StudioBuilder
    {
        public Studio28mBuilder()
        {
            studio = new Studio28m();
        }

        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(200000.00M);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("Fina Investi Imoveis");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Piso Vinilico");
        }
    }
}

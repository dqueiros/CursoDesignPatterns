using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsCriacao.Prototype
{
    public class GerenciadorVendasStudio
    {
        private Dictionary<string, StudioModel> studioModel = new Dictionary<string, StudioModel>();
        public StudioModel this[string key]
        {
            get { return studioModel[key]; }
            set { studioModel[key] = value; }
        }
    }
}

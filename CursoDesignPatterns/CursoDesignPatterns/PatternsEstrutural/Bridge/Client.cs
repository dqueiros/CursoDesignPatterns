using CursoDesignPatterns.PatternsEstrutural.Bridge.Abstracao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsEstrutural.Bridge
{
    public class Client
    {
        public IMaterial Material { get; set; }

        public void ConsultarCanetasPinceisNoEstoque()
        {
            Console.WriteLine(this.Material.ConsultaNoEstoque());
        }
    }
}

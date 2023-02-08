
using CursoDesignPatterns.PatternsComportamental.Strategy.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Strategy.Model;
using CursoDesignPatterns.PatternsComportamental.Strategy.Servicos;

namespace CursoDesignPatterns.PatternsComportamental.Strategy
{
    public class RotinaTaxaServicos
    {
        public void ExecutaRotina()
        {
            var cobertura01 = new Orcamento(1, 70, 30, Enum.PorcetagemServicos.Cobertura);
            var cobertura02 = new Orcamento(2, 70, 65, Enum.PorcetagemServicos.Cobertura);

            var master01 = new Orcamento(3, 50, 20, Enum.PorcetagemServicos.Master, true);
            var master02 = new Orcamento(4, 50, 60, Enum.PorcetagemServicos.Master, true);
            var master03 = new Orcamento(5, 50, 15, Enum.PorcetagemServicos.Master);

            var premium01 = new Orcamento(6, 40, 23, Enum.PorcetagemServicos.Premium, true);
            var premium02 = new Orcamento(7, 40, 23, Enum.PorcetagemServicos.Premium);

            var tradicional01 = new Orcamento(8, 30, 20, Enum.PorcetagemServicos.Tradicional);
            var tradicional02 = new Orcamento(9, 30, 32, Enum.PorcetagemServicos.Tradicional, true);

            var orcamentosSevicos = new List<IServico>()
            {
                new CoberturaServico(tradicional01),
                new CoberturaServico(tradicional02),
                new MasterServico(master01),
                new MasterServico(master02),
                new MasterServico(master03),
                new PremiumServico(premium01),
                new PremiumServico(premium02),
                new TradicionalServico(tradicional01),
                new TradicionalServico(tradicional02)
            };

            CalculaTaxaServicos calcula = new CalculaTaxaServicos();
            calcula.Calcular(orcamentosSevicos);

        }
    }
}

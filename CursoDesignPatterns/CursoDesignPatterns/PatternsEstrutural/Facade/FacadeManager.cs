
using CursoDesignPatterns.PatternsEstrutural.Facade.AmbienteComplexo;

namespace CursoDesignPatterns.PatternsEstrutural.Facade
{
    public class FacadeManager
    {
        public void ExecutarComplexidade()
        {
            ZonaNorte zonaNorte = new ZonaNorte();
            ZonaSul zonaSul = new ZonaSul();
            CloudComputing cloud = new CloudComputing();

            var sul = zonaSul.ExecutaRotinaVendasPerdidas(DateTime.Now);
            var norte = zonaNorte.ExecutaRotinaVendasPerdidas(DateTime.Now);

            cloud.GerarRelatorioPerdasGanhos(sul, norte);
        }
    }
}

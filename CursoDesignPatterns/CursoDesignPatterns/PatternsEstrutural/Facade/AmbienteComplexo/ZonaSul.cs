
namespace CursoDesignPatterns.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaSul
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            //Executa store procedure para itens vendas perdidas e regras de negócio SQL Server
            Console.WriteLine("[!] - Executando complexidade rotinas vendas perdidas região sul");

            return new List<object>();
        }
    }
}


namespace CursoDesignPatterns.PatternsEstrutural.Facade.AmbienteComplexo
{
    public class ZonaNorte
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            //Executa store procedure para itens vendas perdidas e região Norte MySQL
            Console.WriteLine("[!] - Executando complexidade rotinas vendas perdidas região Norte");

            return new List<object>();
        }
    }
}

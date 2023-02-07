
namespace CursoDesignPatterns.PatternsEstrutural.Adapter
{
    public class BusinessLegado
    {
        public string ExecutarRotinasContasPagar(string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            
            Console.WriteLine("\nProcessando regra de negócio contas a pagar. . .");
            //Aplicando as regras
            Thread.Sleep(3000);

            return result;
        }

        public string ExecutarRotinasContasReceber(string mes)
        {
            var result = AcessoSQL.GetDadosReceber(mes);

            Console.WriteLine("\nProcessando regra de negócio contas a receber. . .");
            //Aplicando as regras
            Thread.Sleep(3000);

            return result;
        }
    }

    public class AcessoSQL
    {
        public static string GetDadosPagar(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Junho", "Junho\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Julho", "Julho\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Agosto", "Agosto\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Setembro", "Setembro\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Outubro", "Outubro\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");

            return dic[mes];
        }

        public static string GetDadosReceber(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Junho", "Junho\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Julho", "Julho\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Agosto", "Agosto\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Setembro", "Setembro\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");
            dic.Add("Outubro", "Outubro\nCNPJ: 55010051000196\nRazão Social: Lojas Prudentes\nValor: 1200.00\nContato: (15) 3118-7727");

            return dic[mes];
        }
    }
}

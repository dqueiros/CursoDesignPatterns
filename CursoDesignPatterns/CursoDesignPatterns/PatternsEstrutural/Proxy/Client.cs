
using CursoDesignPatterns.PatternsEstrutural.Proxy.Model;

namespace CursoDesignPatterns.PatternsEstrutural.Proxy
{
    public class Client
    {
        public void TentarConexaoClientVPN()
        {
            VPNProxy proxy = new VPNProxy();

            Console.Write("Digite o Username: ");
            string username = Console.ReadLine();

            Console.Write("Digite o Password: ");
            string password = Console.ReadLine();

            var user = new User(username, password);
            proxy.AcessarVPN(user);
        }
    }
}

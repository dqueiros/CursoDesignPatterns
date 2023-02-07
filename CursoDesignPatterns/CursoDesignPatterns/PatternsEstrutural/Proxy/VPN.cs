using CursoDesignPatterns.PatternsEstrutural.Proxy.Interface;
using CursoDesignPatterns.PatternsEstrutural.Proxy.Model;

namespace CursoDesignPatterns.PatternsEstrutural.Proxy
{
    public class VPN : IProxy
    {
        public void AcessarVPN(User user)
        {
            Console.WriteLine("[+] - ACESSANDO VPN\n");
            Thread.Sleep(2000);
            Console.WriteLine($"{user.Username}, você está logado na VPN");
        }
    }
}

using CursoDesignPatterns.PatternsEstrutural.Proxy.Interface;
using CursoDesignPatterns.PatternsEstrutural.Proxy.Model;
using CursoDesignPatterns.PatternsEstrutural.Proxy.SQL;

namespace CursoDesignPatterns.PatternsEstrutural.Proxy
{
    public class VPNProxy : IProxy
    {
        public void AcessarVPN(User user)
        {
            DataBaseConnection sql = new DataBaseConnection();
            sql.RegistrarAcessoVPN(user);
            Console.WriteLine(new String('-',40));
            VPN vpn = new VPN();
            vpn.AcessarVPN(user);
        }
    }
}

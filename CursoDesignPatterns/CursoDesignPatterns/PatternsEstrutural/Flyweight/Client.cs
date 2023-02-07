
namespace CursoDesignPatterns.PatternsEstrutural.Flyweight
{
    public class Client
    {
        List<string> coresTamanhos = new List<string>()
        {
            "Azul:Pequena","Cinza:Média","Vermelha:Grande",
            "Azul:Pequena","Cinza:Média","Vermelha:Grande",
            "Azul:Pequena","Cinza:Média","Vermelha:Grande"
        };
        public void ConsumirFlyweights()
        {
            FlyweightFactory factory = new FlyweightFactory();

            foreach (var item in coresTamanhos)
            {
                var cor = item.Split(":")[0];
                var tamanho = item.Split(":")[1];
                var espacoNave = factory.GetEspacoNave(cor);
                espacoNave.Exibir(cor, tamanho);
            }
        }
    }
}

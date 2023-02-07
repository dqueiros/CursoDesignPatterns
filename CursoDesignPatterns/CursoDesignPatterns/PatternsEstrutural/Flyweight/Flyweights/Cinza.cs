using CursoDesignPatterns.PatternsEstrutural.Flyweight.Model;

namespace CursoDesignPatterns.PatternsEstrutural.Flyweight.Flyweights
{
    public class Cinza : EspacoNave
    {
        public Cinza()
        {
            this.condicao = "voando em linha reta -";
            this.acao = "disparando lasers";
        }
        public override void Exibir(string cor, string tamanho)
        {
            this.condicao = cor;
            this.acao = tamanho;

            Console.WriteLine($"Nave {this.tamanho} e {this.cor} {this.condicao} {this.acao}");
        }
    }
}

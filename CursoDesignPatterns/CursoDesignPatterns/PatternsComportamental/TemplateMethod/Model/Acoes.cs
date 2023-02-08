
namespace CursoDesignPatterns.PatternsComportamental.TemplateMethod.Model
{
    public class Acoes
    {
        public Acoes()
        {

        }

        public Acoes(string singla, int quantidade, double valorUnitario)
        {
            Singla = singla;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public string Singla { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}

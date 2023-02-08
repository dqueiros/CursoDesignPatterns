
namespace CursoDesignPatterns.PatternsComportamental.Visitor.Interfaces
{
    public interface IProduct
    {
        public string Nome { get; set; }
        public double Peso { get; set; }

        public double GetImposto(IVisitor visitor);
    }
}

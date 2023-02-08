
namespace CursoDesignPatterns.PatternsComportamental.Observer.Interfaces
{
    public interface ISujeito
    {
        List<IObservavel> Observaveis { get; set; }
        void AddObservavel(IObservavel observavel);
        void RemoveObservavel(IObservavel observavel);
        void NotificarObservavel();
    }
}

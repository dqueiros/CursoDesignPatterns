
namespace CursoDesignPatterns.PatternsComportamental.Iterator.Interfaces
{
    public interface IIterator
    {
        string Next { get; }
        bool HasNext { get; }
    }
}

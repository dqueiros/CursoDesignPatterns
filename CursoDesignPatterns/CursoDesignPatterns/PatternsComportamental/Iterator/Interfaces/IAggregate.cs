
namespace CursoDesignPatterns.PatternsComportamental.Iterator.Interfaces
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int index] { get; set; }
        public int Limit { get; }

    }
}

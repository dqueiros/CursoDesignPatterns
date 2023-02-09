
namespace CursoDesignPatterns.PatternsComportamental.Memento
{
    public class Videocassete
    {
        public void ExecutarAcaoVideo()
        {
            Originator originator = new Originator();
            originator.Estado = "play";

            Caretaker caretaker = new Caretaker();
            caretaker.AddSnapshot(originator.CreateSnapshot());

            originator.Estado = "pause";
            
            originator.Restore(caretaker.GetSnapshot());
        }
    }
}

using CursoDesignPatterns.PatternsComportamental.Observer.Interfaces;

namespace CursoDesignPatterns.PatternsComportamental.Observer.Subjects
{
    public class PrimeVideos : ISujeito
    {
        public List<IObservavel> Observaveis { get; set; }
        public PrimeVideos()
        {
            Observaveis = new List<IObservavel>();
        }

        public void AddObservavel(IObservavel observavel)
        {
            Observaveis.Add(observavel);
        }

        public void NotificarObservavel()
        {
            foreach (var observavel in Observaveis)
            {
                observavel.Update();
                Console.WriteLine(new String('-',50));
            }
        }

        public void RemoveObservavel(IObservavel observavel)
        {
            Observaveis.Remove(observavel);
        }
    }
}

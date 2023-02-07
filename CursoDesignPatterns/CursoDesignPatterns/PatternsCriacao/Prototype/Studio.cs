
namespace CursoDesignPatterns.PatternsCriacao.Prototype
{
    public class Studio : StudioModel
    {
        private string _tipoStudio;
        private string _tipoFinanciamento;
        private decimal _valorStudio;

        public Studio(string tipoStudio, string tipoFinanciamento, decimal valorStudio)
        {
            _tipoStudio = tipoStudio;
            _tipoFinanciamento = tipoFinanciamento;
            _valorStudio = valorStudio;
        }

        public override StudioModel Clone()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"Studio clonado: {_tipoStudio}\nFinanciamento: {_tipoFinanciamento}\nValor: {_valorStudio.ToString("C")}\n");
            return this.MemberwiseClone() as StudioModel;
        }
    }
}

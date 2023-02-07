
using CursoDesignPatterns.PatternsEstrutural.Bridge.Implementacao.Interface;

namespace CursoDesignPatterns.PatternsEstrutural.Bridge.Implementacao
{
    public class Preto : ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            // Implementa complexidade de consultar no banco de dados quantidade por cor
            var random = new Random();
            var quantidade = random.Next(100, 500);

            return $"Existem {quantidade} iten(s) para {tipoAbstracao} de cor Preto no estoque.";
        }
    }
}

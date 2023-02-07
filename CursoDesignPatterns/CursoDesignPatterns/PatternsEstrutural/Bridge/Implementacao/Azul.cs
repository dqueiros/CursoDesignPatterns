using CursoDesignPatterns.PatternsEstrutural.Bridge.Implementacao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsEstrutural.Bridge.Implementacao
{
    public class Azul : ICor
    {
        public string ConsultarQuantidadePorCor(string tipoAbstracao)
        {
            // Implementa complexidade de consultar no banco de dados quantidade por cor
            var random = new Random();
            var quantidade = random.Next(100, 500);

            return $"Existem {quantidade} iten(s) para {tipoAbstracao} de cor Azul no estoque.";
        }
    }
}

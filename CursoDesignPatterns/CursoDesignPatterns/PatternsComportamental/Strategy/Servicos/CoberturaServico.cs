using CursoDesignPatterns.PatternsComportamental.Strategy.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Strategy.Model;

namespace CursoDesignPatterns.PatternsComportamental.Strategy.Servicos
{
    public class CoberturaServico : IServico
    {
        private Orcamento _orcamento;

        public CoberturaServico(Orcamento orcamento)
        {
            this._orcamento = orcamento;
        }
        public void CalcularServico()
        {
            var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagem;

            if (_orcamento.Quantidade > 60)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;
                Console.WriteLine($"Conta superior a 60 dias recebe 3% desconto para cobertura\n");
            }

            Console.WriteLine($"Tipo Quarto: {_orcamento.Porcentagem}\nPorcentagem Serviço: {porcentagem.ToString("C")}\n" +
                $"Quant. Dias: {_orcamento.Quantidade}\nValor Dia: {_orcamento.ValorDiaria}\nValor Total: " +
                $" {_orcamento.ValorTotal}");
        }
    }
}


using System.Windows.Markup;

namespace CursoDesignPatterns.PatternsComportamental.Command.Receivers
{
    public class LuzLuminariaReceiver
    {
        private bool _estaLigada = false;
        private int _intensidade = 100;

        public string GetEstadoLuminaria() => _estaLigada ? "Ligada" : "Desligada";

        public void LigarLuz()
        {
            if (_estaLigada)
            {
                Console.WriteLine($"A luz já está ligada.");
            }
            else
            {
                _estaLigada = !_estaLigada;
                Console.WriteLine($"A luz foi {GetEstadoLuminaria()}");
            }

        }

        public void DesligaLuz()
        {
            if (!_estaLigada)
            {
                Console.WriteLine($"A luz já está desligada.");
            }
            else
            {
                _estaLigada = !_estaLigada;
                Console.WriteLine($"A luz foi {GetEstadoLuminaria()}");
            }
        }

        public void AumentarIntesidade()
        {
            if(_intensidade >= 0 && _intensidade < 100)
            {
                _intensidade += 20;
                Console.WriteLine($"Intensidade foi aumentada para {_intensidade}%");
            }
            else 
            {
                Console.WriteLine($"A intensidade está em {_intensidade}%");
            }
        }

        public void DiminuirIntensidade()
        {
            if (_intensidade > 0 && _intensidade <= 100)
            {
                _intensidade -= 20;
                Console.WriteLine($"Intensidade foi diminuida para {_intensidade}%");
            }
            else 
            {
                Console.WriteLine($"Intensidade está em {_intensidade}%");
            }
        }
    }
}

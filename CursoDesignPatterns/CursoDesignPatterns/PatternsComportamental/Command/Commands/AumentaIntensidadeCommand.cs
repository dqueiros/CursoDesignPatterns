
using CursoDesignPatterns.PatternsComportamental.Command.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Command.Receivers;

namespace CursoDesignPatterns.PatternsComportamental.Command.Commands
{
    public class AumentaIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public AumentaIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }
        public void Execute()
        {
            _luzLuminariaReceiver.AumentarIntesidade();
        }
    }
}

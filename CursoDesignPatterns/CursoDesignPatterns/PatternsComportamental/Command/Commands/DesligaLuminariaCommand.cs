
using CursoDesignPatterns.PatternsComportamental.Command.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Command.Receivers;

namespace CursoDesignPatterns.PatternsComportamental.Command.Commands
{
    public class DesligaLuminariaCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public DesligaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.DesligaLuz();
        }
    }
}

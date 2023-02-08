
using CursoDesignPatterns.PatternsComportamental.Command.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Command.Receivers;

namespace CursoDesignPatterns.PatternsComportamental.Command.Commands
{
    public class DiminuiIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public DiminuiIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }
        public void Execute()
        {
            _luzLuminariaReceiver.DiminuirIntensidade();
        }
    }
}

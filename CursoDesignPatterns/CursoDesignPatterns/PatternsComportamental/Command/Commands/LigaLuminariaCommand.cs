
using CursoDesignPatterns.PatternsComportamental.Command.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Command.Receivers;

namespace CursoDesignPatterns.PatternsComportamental.Command.Commands
{
    public class LigaLuminariaCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public LigaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.LigarLuz();
        }
    }
}

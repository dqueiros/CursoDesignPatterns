
using CursoDesignPatterns.PatternsComportamental.Command.Interfaces;

namespace CursoDesignPatterns.PatternsComportamental.Command
{
    public class ControleInvoker
    {
        private Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();

        public void AddCommand(string key, ICommand command)
        {
            this.Commands.Add(key, command);
        }

        public void ExecutarCommand(string key)
        {
            if (!this.Commands.Keys.Contains(key))
            {
                Console.WriteLine($"Comando inexistente");
            }
            else
            {
                this.Commands[key].Execute();
            }
        }
    }
}

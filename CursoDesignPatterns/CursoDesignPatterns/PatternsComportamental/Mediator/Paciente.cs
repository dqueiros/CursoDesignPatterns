
using CursoDesignPatterns.PatternsComportamental.Mediator.AbstractModel;

namespace CursoDesignPatterns.PatternsComportamental.Mediator
{
    public class Paciente : Contato
    {
        public Paciente(Mediador mediador) 
            : base(mediador)
        {
        }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Paciente escrevendo...");
            Thread.Sleep(3000);
            this.Mediador.Enviar(mensagem, this);
            Thread.Sleep(3000);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine($"Para Paciente: {mensagem}");
        }
    }
}

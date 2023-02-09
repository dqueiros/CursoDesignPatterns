
using System.Runtime.InteropServices;

namespace CursoDesignPatterns.PatternsComportamental.Mediator
{
    public class Chat
    {
        public void Conversar()
        {
            MediadorConcreto mediador = new MediadorConcreto();
            
            Atendente atendente = new Atendente(mediador);
            Paciente paciente = new Paciente(mediador);

            mediador.Atendente = atendente;
            mediador.Paciente = paciente;

            Console.WriteLine("Chat: ");
            paciente.EnviarMensagem("Por favor, eu gostaria de agendar uma consulta.");
            atendente.EnviarMensagem("Sim, por favor, em qual especialidade?");

            paciente.EnviarMensagem("Clinico Geral.");
            atendente.EnviarMensagem("Temos vagas para próxima terça nos horário:\n16:30hs\n16:45hs\n17:00hs\n");

            paciente.EnviarMensagem("Pode agendar terça às 16:45");
            atendente.EnviarMensagem("Agendamento concluído com sucesso!");

            paciente.EnviarMensagem("Obrigado...");
            atendente.EnviarMensagem("Nós que agradecemos!");

            Console.WriteLine(new String('-',40));
        }
    }
}


using CursoDesignPatterns.PatternsComportamental.Observer.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Observer.Model;

namespace CursoDesignPatterns.PatternsComportamental.Observer.Observers
{
    public class NaoAssinante : IObservavel
    {
        public NaoAssinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }

        public Pessoa Pessoa { get; set; }
        public string Mensagem { get; set; }
        public void Update()
        {
            //Simular envio de email para não assinante
            Console.WriteLine($"Enviando e-mail para: {Pessoa.Email}\n");
            Console.WriteLine($"Prezado {Pessoa.Nome}\n{Mensagem}");

            Console.WriteLine($"\nINSERT INTO TB_NOTIFICACAO (PessoaId, Notificado,Mes) VALUES ({Pessoa.Id},1,{DateTime.Now.Month})\n");
        }
    }
}

using CursoDesignPatterns.PatternsComportamental.Observer.Interfaces;
using CursoDesignPatterns.PatternsComportamental.Observer.Model;
using CursoDesignPatterns.PatternsComportamental.Observer.Observers;
using CursoDesignPatterns.PatternsComportamental.Observer.Subjects;
using System.Globalization;

namespace CursoDesignPatterns.PatternsComportamental.Observer
{
    public class SendMail
    {
        public void EnviarEmail()
        {
            string msgNaoAssinante = $"Notamos que ainda não faz parte da maior e melhor plataforma de séries e " +
                $"filmes, não fique de fora da promoção de {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} " +
                $"e acesse nossa plataforma para ver os mais recentes lançamentos.";

            string msgAssinante = $"Laçamentos para o mês {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} " +
                $"direto do cinema para sua tela.";

            List<IObservavel> observaveis = new List<IObservavel>()
            {
                new NaoAssinante(new Pessoa(1,"José", "jose@gmail.com"), msgNaoAssinante),
                new NaoAssinante(new Pessoa(2,"Maria", "maria@gmail.com"), msgNaoAssinante),
                new Assinante(new Pessoa(3,"João", "joao@gmail.com"), msgAssinante),
                new Assinante(new Pessoa(3,"Marta", "marta@gmail.com"), msgAssinante)
            };

            PrimeVideos primeVideos = new PrimeVideos();

            foreach (var o in observaveis)
            {
                primeVideos.AddObservavel(o);
            }

            primeVideos.NotificarObservavel();
        }
    }
}

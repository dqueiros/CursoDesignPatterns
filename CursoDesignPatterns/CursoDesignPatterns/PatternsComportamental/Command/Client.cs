
using CursoDesignPatterns.PatternsComportamental.Command.Commands;
using CursoDesignPatterns.PatternsComportamental.Command.Receivers;

namespace CursoDesignPatterns.PatternsComportamental.Command
{
    public class Client
    {
        public void FalarComandos()
        {
            var lumnaria = new LuzLuminariaReceiver();

            ControleInvoker controle = new ControleInvoker();
            controle.AddCommand("LigaLuz", new LigaLuminariaCommand(lumnaria));
            controle.AddCommand("DesligaLuz", new DesligaLuminariaCommand(lumnaria));
            controle.AddCommand("AumentaIntensidade", new AumentaIntensidadeCommand(lumnaria));
            controle.AddCommand("DiminuiIntensidade", new DiminuiIntensidadeCommand(lumnaria));

            controle.ExecutarCommand("LigaLuz");

            //teste
            controle.ExecutarCommand("AumentaIntensidade");
            
            controle.ExecutarCommand("DiminuiIntensidade");
            controle.ExecutarCommand("DiminuiIntensidade");
            controle.ExecutarCommand("DiminuiIntensidade");
            controle.ExecutarCommand("DiminuiIntensidade");
            controle.ExecutarCommand("DiminuiIntensidade");
            
            //teste
            controle.ExecutarCommand("DiminuiIntensidade");

            controle.ExecutarCommand("AumentaIntensidade");
            controle.ExecutarCommand("AumentaIntensidade");
            controle.ExecutarCommand("AumentaIntensidade");
            controle.ExecutarCommand("AumentaIntensidade");
            controle.ExecutarCommand("AumentaIntensidade");

            //teste
            controle.ExecutarCommand("AumentaIntensidade");

            controle.ExecutarCommand("DesligaLuz");

        }
    }
}

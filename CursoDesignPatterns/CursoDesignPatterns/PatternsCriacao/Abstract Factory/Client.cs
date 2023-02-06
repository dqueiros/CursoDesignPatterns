using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Factories;
using CursoDesignPatterns.PatternsCriacao.Abstract_Factory.ParteCriacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsCriacao.Abstract_Factory
{
    public class Client
    {
        public void ConsultarRotinaAluno()
        {
            var continuar = true;


            while (continuar)
            {
                IFactory factory = null;

                Console.WriteLine("Selecione a rotina desejada");
                Console.WriteLine("1-Segunda Feira e Quinta Feira");
                Console.WriteLine("2-Terça Feira e Sexta Feira");
                Console.WriteLine("3-Quarta Feira e Sábado");
                
                Console.Write("Selecione a rotina desejada: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        factory = new SegundaQuintaFactory();
                        break;
                    case "2":
                        factory = new TercaSextaFactory();
                        break;
                    case "3":
                        factory = new QuartaSabadoFactory();
                        break;
                    default:
                        break;
                }

                Console.Write("Deseja ver outra rotina? (1-Sim ou 2-Não): ");
                int resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1;

            }
        }
    }
}

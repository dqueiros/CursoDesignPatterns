using CursoDesignPatterns.PatternsCriacao.FactoryMethod.Enums;

namespace CursoDesignPatterns.PatternsCriacao.FactoryMethod
{
    public class Client
    {
        public void ExecutarCriacaoProduto()
        {
            var client = new SelecionaServico();
            var continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecione o tipo de serviço:\n");
                Console.WriteLine("0 - Tradicional");
                Console.WriteLine("1 - Premium");
                Console.WriteLine("2 - Master");
                Console.WriteLine("3 - Cobertura");

                Console.Write("Digite o número do serviço que deseja cobrar: ");
                int tipoServico = Convert.ToInt32(Console.ReadLine());

                var servicoProduto = client.Fabricarproduto((eTiposServicos)tipoServico);
                Console.WriteLine($"Tipo: {servicoProduto.GetType().Name}");

                Console.Write("Deseja calcular outro serviço? (1-Sim ou 2-Não): ");
                int resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1;
            }
        }
    }
}

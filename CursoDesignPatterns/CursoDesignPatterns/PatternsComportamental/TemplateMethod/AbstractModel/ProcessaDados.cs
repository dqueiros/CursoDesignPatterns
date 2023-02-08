
using CursoDesignPatterns.PatternsComportamental.TemplateMethod.Model;

namespace CursoDesignPatterns.PatternsComportamental.TemplateMethod.AbstractModel
{
    public abstract class ProcessaDados
    {
        protected List<Pessoa> pessoas;
        protected string json;
        protected string xml;

        protected ProcessaDados(string xml = "", string json = "")
        {
            if (!string.IsNullOrEmpty(xml))
                this.xml = xml;
            else if (!string.IsNullOrEmpty(json))
                this.json = json;

            this.pessoas = new List<Pessoa>();
        }

        public virtual void ProcessarXML() { }
        public virtual void ProcessarJSON() { }
        protected void ApresentarValores()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(new String('#',40));

                Console.WriteLine($"Cliente: {pessoa.Nome}\n");
                double valorTotal = 0;

                foreach (var acao in pessoa.Acoes)
                {
                    Console.WriteLine(new String('-', 30));
                    valorTotal += acao.ValorUnitario * acao.Quantidade;

                    Console.WriteLine($"Sigla: {acao.Singla}\nValor Unitário: {acao.ValorUnitario.ToString("C")}\nQuantidade: {acao.Quantidade}\nValor Total: {valorTotal.ToString("C")}");
                }
            }
        }
    }
}

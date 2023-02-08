using CursoDesignPatterns.PatternsComportamental.TemplateMethod.AbstractModel;
using CursoDesignPatterns.PatternsComportamental.TemplateMethod.Model;
using Newtonsoft.Json;

namespace CursoDesignPatterns.PatternsComportamental.TemplateMethod
{
    public class ConvertJSON : ProcessaDados
    {
        public ConvertJSON(string json = "")
            : base(json:json)
        {
        }

        public override void ProcessarJSON()
        {
            this.pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(this.json);
            this.ApresentarValores();
        }
    }
}

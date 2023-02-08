using CursoDesignPatterns.PatternsComportamental.TemplateMethod.Model;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace CursoDesignPatterns.PatternsComportamental.TemplateMethod
{
    public class ObtemDadosAPI
    {
        public static string EndPointXML()
        {
            List<Pessoa> pessoas = GetPessoas();
            XmlSerializer serializer = new XmlSerializer(pessoas.GetType());
            string xml = String.Empty;

            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, pessoas);
                xml = sw.ToString();
            }

            return xml;
        }

        public static string EndpointJSON()
        {
            List<Pessoa> pessoas = GetPessoas();
            var json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            return json;
        }

        private static List<Pessoa> GetPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa()
                {
                    Nome = "José",
                    CPF = "979.587.210-99",
                    Acoes = new List<Acoes>()
                    {
                        new Acoes("AAAA3", 50, 15.44),
                        new Acoes("BBBB4", 80, 22.34),
                    }
                },
                new Pessoa()
                {
                    Nome = "Magali",
                    CPF = "505.338.120-89",
                    Acoes = new List<Acoes>()
                    {
                        new Acoes("GGGG6", 50, 15.44),
                        new Acoes("TRRR3", 80, 22.34),
                    }
                },
            };
        }
    }
}

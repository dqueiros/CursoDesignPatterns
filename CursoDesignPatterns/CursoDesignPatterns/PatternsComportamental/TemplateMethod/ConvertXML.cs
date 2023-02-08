
using CursoDesignPatterns.PatternsComportamental.TemplateMethod.AbstractModel;
using CursoDesignPatterns.PatternsComportamental.TemplateMethod.Model;
using System.Xml;
using System.Xml.Serialization;

namespace CursoDesignPatterns.PatternsComportamental.TemplateMethod
{
    public class ConvertXML : ProcessaDados
    {
        public ConvertXML(string xml = "")
            : base(xml:xml)
        {
        }

        public override void ProcessarXML()
        {
            XmlSerializer serialize = new XmlSerializer(this.pessoas.GetType());

            var stringReader = new StringReader(this.xml);

            using (var reader = XmlReader.Create(stringReader))
            {
                this.pessoas = (List<Pessoa>)serialize.Deserialize(reader);
            }

            this.ApresentarValores();
        }
    }
}

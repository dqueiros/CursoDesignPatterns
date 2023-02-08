
namespace CursoDesignPatterns.PatternsComportamental.TemplateMethod
{
    public class Client
    {
        public void ConsumirEndpointXML()
        {
            Console.WriteLine("\n__________XML__________\n");

            var xml = ObtemDadosAPI.EndPointXML();
            ConvertXML convertXML = new ConvertXML(xml);

            convertXML.ProcessarXML();
        }

        public void ConsumirEndpointJSON()
        {

            Console.WriteLine("\n__________JSON__________\n");

            var json = ObtemDadosAPI.EndpointJSON();
            ConvertJSON convertJSON = new ConvertJSON(json);

            convertJSON.ProcessarJSON();
        }
    }
}

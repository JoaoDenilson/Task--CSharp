using Library;
using System.Xml.Serialization;
namespace _02_SerializeXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name = "Joao",
                CPF = "222.222.222.22",
                Email = "Joao@gmail.com",
            };

            XmlSerializer serializador = new XmlSerializer(typeof(User));

            StreamWriter stream = new StreamWriter(@"C:\Projects_C#\Curso_CSharp\ArquivosC#\01_serializarXML.xml");

            serializador.Serialize(stream, user);
        }
    }
}
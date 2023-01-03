using Library;
using System.Xml.Serialization;
namespace _01_DeserializeXML
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader stream = new StreamReader(@"C:\Projects_C#\Curso_CSharp\ArquivosC#\01_serializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(User));

            User user = (User)serializador.Deserialize(stream);

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}", user.Name, user.CPF, user.CPF);
            Console.ReadKey();
        }
    }
}
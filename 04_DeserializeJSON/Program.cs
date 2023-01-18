using Library;
using System.Text.Json;

namespace _04_DeserializeJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Projects_C#\Curso_CSharp\ArquivosC#\usuario.json";
            string jsonString = File.ReadAllText(fileName);
            User user = JsonSerializer.Deserialize<User>(jsonString)!;

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}", user.Name, user.CPF, user.Email);
            Console.ReadKey();
        }
    }
}
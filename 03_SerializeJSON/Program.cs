using Library;
using System.Text.Json;

namespace _03_SerializeJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name = "Maria",
                CPF = "333.333.333.33",
                Email = "Maria@gmail.com",
            };

            string fileName = @"C:\Projects_C#\Curso_CSharp\ArquivosC#\usuario.json";
            string jsonString = JsonSerializer.Serialize(user);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
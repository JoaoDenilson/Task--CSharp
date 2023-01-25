using System.ComponentModel.DataAnnotations;
namespace _11_DataAnnotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User() {Name = "Joao", Email = "JoaoEmail", Password = "123456"};

            ValidationContext context = new ValidationContext(user);
            List<ValidationResult> results = new List<ValidationResult>();

            if (Validator.TryValidateObject(user, context, results, true) == false) 
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            };
            Console.ReadKey();
        }
    }
}
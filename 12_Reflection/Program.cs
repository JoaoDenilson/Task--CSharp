using _12_Reflection.Model;

namespace _12_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User user = new User() 
           {
               Name= "Joao",
               Email = "Joao@hotail",
               Password = "123456"
           };

           Log.RegisterLog(user.Clone());

           user.Name = "Joao Denilson";
           Log.RegisterLog(user.Clone());

            Car car = new Car()
            {
                CarModel = "FIAT",
                Stamp = "UNO"
            };
            Log.RegisterLog(car);

            Log.ShowLog();

           Console.WriteLine("Log gravado.");
            Console.ReadKey();
        }
    }
}
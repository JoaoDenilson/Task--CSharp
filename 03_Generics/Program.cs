using _03_Generics.Model;
namespace _03_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Stamp = "FIAT", CarModel="UNO"};
            House house = new House() { City = "Cedro", Address = "Rua dos Grilos" };
            User user = new User() { Name= "Maria", Email = "Maria@Hotamil", Password = "123456"};

            Serialize.Serializer(car);
            Serialize.Serializer(house);
            Serialize.Serializer(user);

            Car car2 = Serialize.Derializer<Car>();
            House house2 = Serialize.Derializer<House>();
            User user2 = Serialize.Derializer<User>();

            Console.WriteLine("Carro2(Marca): {0}, Modelo: {1}", car2.Stamp, car2.CarModel);
            Console.WriteLine("Casa2(Cidade): {0}, Endereço: {1}", house2.City, house2.Address);
            Console.WriteLine("Usuario2(Nome): {0}, Email: {1}", user2.Name, user2.Email);
            Console.ReadKey();
        }
    }
}
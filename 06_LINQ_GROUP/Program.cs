namespace _06_LINQ_GROUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //var listFilter = listNum.Distinct().OrderBy(x =>x).Select(x => x);
            //var listFilter = listNum.OrderBy(x =>x);
            var listFilter = listNum.OrderBy(x => x).GroupBy(x => x).Select(x => x);

            foreach (var item in listFilter)
            {
                Console.WriteLine(item.Key);
            }
            Console.ReadKey();
        }
    }
}
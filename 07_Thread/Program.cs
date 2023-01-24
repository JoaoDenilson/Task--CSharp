using System.Threading;
namespace _07_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StarDate: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadLoap);
                t1.Start();

            }

            Console.ReadKey();
        }
        static void ThreadLoap()
        {
            for (int i=0; i<100; i++)
            {
                Console.WriteLine("Num: "+i);
            }
        }
    }
}
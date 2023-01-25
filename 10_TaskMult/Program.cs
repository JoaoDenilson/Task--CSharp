using System.Net;
namespace _10_TaskMult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Task> tasks = new List <Task> ();
            tasks.Add(Task.Factory.StartNew(Method01));
            tasks.Add(Task.Factory.StartNew(Method01));
            tasks.Add(Task.Factory.StartNew(Method01));
            tasks.Add(Task.Factory.StartNew(Method01));

            Task.WaitAll(tasks.ToArray());

            string[] address = new string[] { "http://www.google.com.br", "http://www.microsoft.com", "http://www.g1.com.br" };

            var listAddress = from end in address select DownloadPage(end);

            Task.WaitAll(listAddress.ToArray());


            Console.WriteLine("Programa finalizado");
            Console.ReadKey();
        }

        static void Method01()
        {
            for (int i = 0;i<100;i++)
            {
                Console.WriteLine("Valor: " + i + " TaskID: " + Task.CurrentId);
            }         
        }

        public static async Task DownloadPage(string end) {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);
            Console.WriteLine("Download - Page: "+ end);
        }
    }
}
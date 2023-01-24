namespace _08_AutoManual
{
    internal class Program
    {
        static ManualResetEvent manua01;
        static AutoResetEvent auto01;

        static void Main(string[] args)
        {
            manua01= new ManualResetEvent(false);
            auto01 = new AutoResetEvent(false);

            //Thread t1 = new Thread(Execution01);
            //t1.Start();
            Thread t2 = new Thread(Execution02);
            t2.Start();


            Thread.Sleep(5000);
            manua01.Set();
            manua01.Reset();

            auto01.Set();

            Thread.Sleep(5000);
            manua01.Set();
            auto01.Set();

            Console.ReadKey();
        }
        static void Execution01()
        {
            Console.WriteLine("01 - Iniciando executa 01");
            manua01.WaitOne();
            Console.WriteLine("02 - Em execução 01 Executa 01");
            Console.WriteLine("03 - Em execução 02 Executa 01");
            manua01.WaitOne();
            Console.WriteLine("04 - Finalizando 01");
        }

        static void Execution02()
        {
            Console.WriteLine("01 - Iniciando executa 02");
            auto01.WaitOne();
            Console.WriteLine("02 - Em execução 01 Executa 02");
            Console.WriteLine("03 - Em execução 02 Executa 02");
            auto01.WaitOne();
            Console.WriteLine("04 - Finalizando 02");
        }
    }
}
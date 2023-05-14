namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Wait wait200 = new Wait(200);
            Wait wait800 = new Wait(800);

            wait200.WaitForValue(counter);
            wait800.WaitForValue(counter);

           
            Thread counterThread = new Thread(counter.GenerateNumbers);
            counterThread.Start();

            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
            
        }
    }
}
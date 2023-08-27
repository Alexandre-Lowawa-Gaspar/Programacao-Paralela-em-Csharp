namespace TaskParallelLibrary_Parallel.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para começar");
            Console.ReadLine();
            ProcessarLaco();
            Console.WriteLine("\n\n");
            //Chamo o método que vamos usar, isto é, For

            Parallel.For(0,11,i=>Console.WriteLine(i + "\t"));
            Console.ReadLine();

        }
        private static void ProcessarLaco() 
        {
        for (int i = 0; i < 11; i++) 
            {
            Console.WriteLine(i+" Thread : = "+ Thread.CurrentThread.ManagedThreadId +"\t");
            Thread.Sleep(500);
            }
        }
    }
}
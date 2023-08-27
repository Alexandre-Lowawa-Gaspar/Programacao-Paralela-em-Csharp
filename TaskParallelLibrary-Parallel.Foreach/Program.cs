using static System.Console;
namespace TaskParallelLibrary_Parallel.Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> desportos = new(){"Futebol","Basquetebol","Tênis","Golf",
                "Vôlei","Andebol", "Karaté", "Boxe", "Natação" };
            WriteLine("Pressione ENTER para começar");
            ReadLine();
            WriteLine("Mostrando a lista no laço foreach\n");

            foreach (string desporto in desportos) 
            {
                WriteLine($"Desporto: {desporto}, ThreadId = {Thread.CurrentThread.ManagedThreadId} \t");
            }
            //Chamo o método que vamos usar, isto é, Parallel.foreach
            WriteLine("Mostrando a lista utilizando o Parallel.foreach\n");
            Parallel.ForEach(desportos, 
                desporto => { 
                    WriteLine($"Desporto: {desporto}, ThreadId = {Thread.CurrentThread.ManagedThreadId} \t");
                });
        }
    }
}
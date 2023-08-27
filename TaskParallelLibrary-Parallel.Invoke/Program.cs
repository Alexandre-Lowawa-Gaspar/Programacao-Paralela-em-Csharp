namespace TaskParallelLibrary_Parallel.Invoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para começar");
            Console.ReadLine();
            //Chamo o método que vamos usar, isto é, Parallel.Invoke
            Parallel.Invoke(()=>{ ExibirDias(); },
                () => { ExibirMeses(); },
                () => { ExibirProvincias(); }
                );

            Console.WriteLine("\n O método Main foi encerrado. Tecle ENTER");
            Console.ReadLine();

        }
        static void ExibirDias()
        {
            string[] dias = {"Segunda-Feira","Terça-Feira","Quarta-Feira","Quinta-Feira"
                    ,"Sexta-Feira","Sábado","Domingo"
            };
            foreach (string dia in dias) 
            { 
            Console.WriteLine($"Dia da Semana: {dia}");
                Thread.Sleep(1500);
            }
        }
        static void ExibirMeses() 
        {
            string[] meses = { "Jan","Fev","Mar","Abr","Mai","Jun","Jul","Ago",
            "Set","Out","Nov","Dez"};
            foreach (string mes in meses) 
            {
                Console.WriteLine($"Mês: {mes}");
                Thread.Sleep(1200);
            }
        }
        static void ExibirProvincias() 
        {
            string[] provincias = { "Luanda", "Bengo", "Cabinda", "Zaire", "Lunda-Sul",
                "Moxico", "Namibe", "Huambo", "Namibe", "Huila", "Cunene", "Malanje" }; 
            foreach(string provincia in provincias) 
            {
            
            Console.WriteLine($"Província: {provincia}");
                Thread.Sleep(2000);
            }
        }
    }
}
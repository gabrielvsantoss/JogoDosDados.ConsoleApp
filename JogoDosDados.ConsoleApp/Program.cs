namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("---------------------");

                Console.Write("Pressione ENTER para lançar um dado");
                Console.ReadLine();

                Random geradordenumerosaleatorios = new Random();
                int resultado = geradordenumerosaleatorios.Next(1, 7);

                Console.WriteLine("---------------------");
                Console.WriteLine($"O valor sorteado foi {resultado}!");
                Console.WriteLine("---------------------");






















                Console.WriteLine("Deseja Continuar? (S/N)");
                string Continuar = Console.ReadLine()!.ToUpper();

                if (Continuar != "S")
                    break;

            }
        }
    }
}

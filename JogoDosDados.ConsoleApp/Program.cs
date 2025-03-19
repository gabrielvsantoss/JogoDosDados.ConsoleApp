namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        const int LimiteLinhaDeChegada = 30;
          static void Main(string[] args)
        {
            while (true)
            {
                int posicaojogador = 0;
                bool JogoEmAndamento = true;

                while (JogoEmAndamento)
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

                    posicaojogador += resultado;

                    if(posicaojogador >= LimiteLinhaDeChegada)
                    {
                        JogoEmAndamento = false;
                        Console.WriteLine("Parabens voce alcançou a linha de chegada!");
                        Console.WriteLine("-----------------------------------------------");
                    }

                    else
                    {
                        Console.WriteLine($"Voce esta na posicao {posicaojogador} de {LimiteLinhaDeChegada}");
                        Console.WriteLine("-----------------------------");
                        Console.ReadLine();
                           
                    }
                }



















                Console.WriteLine("Deseja Continuar? (S/N)");
                string Continuar = Console.ReadLine()!.ToUpper();

                if (Continuar != "S")
                    break;

            }
        }
    }
}

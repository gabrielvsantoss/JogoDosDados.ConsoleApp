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

                    Console.WriteLine($"Voce esta na posicao {posicaojogador} de {LimiteLinhaDeChegada}");
                    Console.WriteLine("-----------------------------");
                    Console.ReadLine();

                    bool  avanco = posicaojogador == 5 || posicaojogador ==  10 || posicaojogador ==  15 || posicaojogador == 25;
                    bool recuo = posicaojogador == 7 || posicaojogador == 13 || posicaojogador == 20;

                      if(avanco)
                    {
                        Console.WriteLine("EVENTO ESPECIAL!: Avanço extra de 3 casas");
                        Console.WriteLine("-------------------------------------------");

                        posicaojogador += 3;
                        Console.WriteLine($"Voce avançou para a posição {posicaojogador}");
                        Console.WriteLine("-------------------------------------------");

                    }


                    else if (recuo)
                    {
                        Console.WriteLine("EVENTO ESPECIAL!: Recuo de 2 casas");
                        Console.WriteLine("-------------------------------------------");

                        posicaojogador -= 2;
                        Console.WriteLine($"Voce  recuo para a posição {posicaojogador}");
                        Console.WriteLine("-------------------------------------------");

                    }

                    if (posicaojogador >= LimiteLinhaDeChegada)
                    {
                        JogoEmAndamento = false;
                        Console.WriteLine("Parabens voce alcançou a linha de chegada!");
                        Console.WriteLine("-----------------------------------------------");
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

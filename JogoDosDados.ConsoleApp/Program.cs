
namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        public const int LimiteLinhaDeChegada = 30;
          static void Main(string[] args)
        {
            while (true)
            {
                 
                bool JogoEmAndamento = true;
                

                while (JogoEmAndamento)
                {
                    Console.Clear();
                    LogicaJogo.Apresentacao();
                    LogicaJogo.RodadaUsuario(LimiteLinhaDeChegada);
                    LogicaJogo.EventosEspeciaisJogador(LimiteLinhaDeChegada, JogoEmAndamento);
                    LogicaJogo.RodadaComputador( LimiteLinhaDeChegada);
                    JogoEmAndamento = LogicaJogo.EventosEspeciaisComputador(LimiteLinhaDeChegada, JogoEmAndamento);
                    LogicaJogo.Desempate(LimiteLinhaDeChegada);
                }
                Console.WriteLine("Deseja Continuar? (S/N)");
                string Continuar = Console.ReadLine()!.ToUpper();

                if (Continuar != "S")
                    break;

            }
        }

        
    }
}

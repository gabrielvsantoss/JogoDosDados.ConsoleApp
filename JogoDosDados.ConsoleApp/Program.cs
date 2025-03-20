
namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        const int LimiteLinhaDeChegada = 30;
          static void Main(string[] args)
        {
            while (true)
            {
                 
                bool JogoEmAndamento = true;
                

                while (JogoEmAndamento)
                {
                    Console.Clear();
                    Dados.Apresentacao();
                    Dados.RodadaUsuario(LimiteLinhaDeChegada);
                    Dados.EventosEspeciaisJogador(LimiteLinhaDeChegada, JogoEmAndamento);
                    Dados.RodadaComputador(  LimiteLinhaDeChegada);
                    JogoEmAndamento = Dados.EventosEspeciaisComputador(LimiteLinhaDeChegada, JogoEmAndamento);
                    Dados.Desempate(LimiteLinhaDeChegada);
                }
                Console.WriteLine("Deseja Continuar? (S/N)");
                string Continuar = Console.ReadLine()!.ToUpper();

                if (Continuar != "S")
                    break;

            }
        }

        
    }
}


namespace JogoDosDados.ConsoleApp
{
    public class Dados
    {
        static int Sortear()
        {
            Random geradordenumeros = new Random();
            int resultado = geradordenumeros.Next(1, 7);
            return resultado;
        }
    }
}

﻿
namespace JogoDosDados.ConsoleApp
{

    public class LogicaJogo
    {
        public static  int posicaojogador = 0;
        public static int posicaocomputador = 0;

        public static int Sortear()
        {
            Random geradordenumeros = new Random();
            int resultado = geradordenumeros.Next(1, 7);
            return resultado;
        }


        public static void Apresentacao()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Jogo dos Dados");
            Console.WriteLine("---------------------");
            Console.WriteLine("Rodada do Usuario");
            Console.WriteLine("---------------------");
        }

        public static int RodadaUsuario(int LimiteLinhaDeChegada)
        {
            int RodadaBonus = 0;

            int resultadoUsuario;
            Console.Write("Pressione ENTER para lançar um dado");
            Console.ReadLine();
            resultadoUsuario = LogicaJogo.Sortear();
            if (resultadoUsuario == 6)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("O valor sorteado foi 6! e voce irá ganhar uma rodada Bonus\n Tecle ENTER para jogar a rodada bonus");
                Console.ReadLine();
                RodadaBonus = LogicaJogo.Sortear();
                Console.WriteLine("---------------------");
                Console.WriteLine($"O valor na rodada  bonus foi {RodadaBonus}!");
                Console.WriteLine("---------------------");
            }
            else if(resultadoUsuario != 6) { 
            Console.WriteLine("---------------------");
            Console.WriteLine($"O valor sorteado foi {resultadoUsuario}!");
            Console.WriteLine("---------------------");
                }
            posicaojogador += resultadoUsuario + RodadaBonus;
            Console.WriteLine($"Voce esta na posicao {posicaojogador} de {LimiteLinhaDeChegada}");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
            return posicaojogador;
        }

        public static int RodadaComputador(int LimiteLinhaDeChegada)
        {
            Console.WriteLine("Rodada do Computador");
            Console.WriteLine("---------------------");
            Console.Write("Pressione ENTER para  visualizar a rodada do Computador");
            Console.ReadLine();
            int RodadaBonusComputador = 0;


            int ResultadoComputador = LogicaJogo.Sortear();
            if (ResultadoComputador == 6)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("O valor sorteado foi 6! O computador irá ganhar uma rodada Bonus\n Tecle ENTER para visualizar a rodada bonus do computador");
                Console.ReadLine();
                RodadaBonusComputador = LogicaJogo.Sortear();
                Console.WriteLine("---------------------");
                Console.WriteLine($"O valor sorteado na rodada bonus do computador foi {RodadaBonusComputador}!");
            }

            else
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"O valor sorteado foi {ResultadoComputador}!");
                Console.WriteLine("---------------------");
            }
            posicaocomputador += ResultadoComputador + RodadaBonusComputador;

            Console.WriteLine($"O computador esta na posicao {posicaocomputador} de {LimiteLinhaDeChegada}");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();

            return posicaocomputador;
        }
        

        public static  bool EventosEspeciaisJogador(int LimiteLinhaDeChegada, bool JogoEmAndamento)
        {
            bool avanco = posicaojogador == 5 || posicaojogador == 10 || posicaojogador == 15 || posicaojogador == 25;
            bool recuo = posicaojogador == 7 || posicaojogador == 13 || posicaojogador == 20;

            if (avanco)
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
                Console.WriteLine($"Voce  recuou para a posição {posicaojogador}");
                Console.WriteLine("-------------------------------------------");
            }

            if (posicaojogador >= LimiteLinhaDeChegada)
            {
                JogoEmAndamento = false;
                Console.WriteLine("Parabens voce alcançou a linha de chegada!");
                Console.WriteLine("-----------------------------------------------");
            }

            return JogoEmAndamento;
        }

        public static bool EventosEspeciaisComputador(int LimiteLinhaDeChegada, bool JogoEmAndamento)
        {


            bool avancoComputador = posicaocomputador == 5 || posicaocomputador == 10 || posicaocomputador == 15 || posicaocomputador == 25;
            bool recuoComputador = posicaocomputador == 7 || posicaocomputador == 13 || posicaocomputador == 20;

            if (avancoComputador)
            {
                Console.WriteLine("EVENTO ESPECIAL!: Avanço extra de 3 casas");
                Console.WriteLine("-------------------------------------------");

                posicaocomputador += 3;
                Console.WriteLine($"O computador avançou para a posição {posicaocomputador}");
                Console.WriteLine("-------------------------------------------");

            }


            else if (recuoComputador)
            {
                Console.WriteLine("EVENTO ESPECIAL!: Recuo de 2 casas");
                Console.WriteLine("-------------------------------------------");

                posicaocomputador -= 2;
                Console.WriteLine($"O computador recuou para a posição {posicaocomputador}");
                Console.WriteLine("-------------------------------------------");
            }

            if (posicaocomputador >= LimiteLinhaDeChegada)
            {
                JogoEmAndamento = false;
                Console.WriteLine("O computador  alcançou a linha de chegada!");
                Console.WriteLine("-----------------------------------------------");
            }

            return JogoEmAndamento;
        }

        public static void Desempate(int LimiteLinhaDeChegada)
        {
            if (posicaojogador >= LimiteLinhaDeChegada && posicaocomputador >= LimiteLinhaDeChegada)
            {
                Console.WriteLine($"Voce e o computador alcançaram a linha de chega na MESMA rodada!");
                Console.WriteLine("Para desempate voce irá rolar o dado novamente junto com o computado");
                Console.WriteLine("O jogador que tirar o maior numero ganha!");
                Console.WriteLine("Tecle ENTER para rodar o dado!");
                Console.ReadLine();
                int resultadoUsuario2 = LogicaJogo.Sortear();
                Console.WriteLine($"Voce tirou {resultadoUsuario2} no dado!");

                Console.WriteLine("Tecle ENTER para visualizar a rodada do computador!");
                Console.ReadLine();
                int ResultadoComputador2 = LogicaJogo.Sortear();
                Console.WriteLine($"O computador tirou {ResultadoComputador2} no dado!");

                if (ResultadoComputador2 > resultadoUsuario2)
                {
                    Console.WriteLine("O computador tirou um numero maior no desempate e ganhou o jogo!");
                    Console.ReadLine();
                }

                else if (ResultadoComputador2 < resultadoUsuario2)
                {
                    Console.WriteLine("Voce tirou um numero maior no desempate e ganhou o jogo!");
                    Console.ReadLine();
                }

            }
        }







    }




}

using Rock_Paper_Scissors.Util;
using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissors.Jogos
{
    public class JogoUnico
    {
        public void partida(List<ModelJogadores> jogadores)
        {
            var jogo = new Jogo().rps_game_winner(jogadores);

            if (jogo == null)
            {
                Console.WriteLine(Program.msgErro);
                Console.ReadLine();
                Program.msgErro = "";
            }
            else
            {
                Console.WriteLine("Winner of the match: " + StringSaida.Format(jogo));
                Console.ReadLine();
            }
        }
    }
}

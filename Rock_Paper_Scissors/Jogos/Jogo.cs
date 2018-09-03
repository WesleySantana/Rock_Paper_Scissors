using Rock_Paper_Scissors.Util;
using System.Collections.Generic;

namespace Rock_Paper_Scissors.Jogos
{
    public class Jogo
    {
        public ModelJogadores rps_game_winner(List<ModelJogadores> jogadores)
        {
            new Validar().Validando(jogadores);

            if (Program.msgErro != "")
                return null;

            return vencedor(jogadores);
        }

        private ModelJogadores vencedor(List<ModelJogadores> jogadores)
        {
            var Jogo1 = jogadores[0].Jogada;
            var Jogo2 = jogadores[1].Jogada;

            if (Jogo1 == Jogo2)
                return jogadores[0];

            var vencedor = jogadores[0];

            switch (Jogo1)
            {
                case "P":
                    vencedor = Jogo2 == "R" ? jogadores[0] : jogadores[1];
                    break;
                case "R":
                    vencedor = Jogo2 == "S" ? jogadores[0] : jogadores[1];
                    break;
                case "S":
                    vencedor = Jogo2 == "P" ? jogadores[0] : jogadores[1];
                    break;
            }

            return vencedor;            
        }
    }
}

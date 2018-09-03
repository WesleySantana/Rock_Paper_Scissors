using Rock_Paper_Scissors.Util;
using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissors.Jogos
{
    public class Torneio
    {        
        public List<List<ModelJogadores>> rps_tournament_winner(List<List<ModelJogadores>> jogadas, int index)
        {
            var vencedor = new ModelJogadores();
            if (jogadas.Count <= index)
            {
                var novaLista = refazerLista(jogadas);
                return rps_tournament_winner(novaLista, 0);
            }
            for (int i = index; i < index + 2; i++)
            {
                if (i == jogadas.Count)
                {
                    Console.WriteLine("Tournament winner: " + StringSaida.Format(vencedor));
                    Console.ReadLine();
                    return null;
                }                    
                var jogo = new Jogo().rps_game_winner(jogadas[i]);
                vencedor = jogo;
                jogadas[i].Remove(jogadas[i].Find(x => x.Jogador != jogo.Jogador));
            }
            return rps_tournament_winner(jogadas, index + 2);
        }

        private List<List<ModelJogadores>> refazerLista(List<List<ModelJogadores>> jogadas)
        {
            var novaLista = new List<List<ModelJogadores>>();
            for (int i = 0; i < jogadas.Count; i += 2)
            {
                novaLista.Add(new List<ModelJogadores> {
                    new ModelJogadores
                    {
                        Jogador = jogadas[i][0].Jogador,
                        Jogada = jogadas[i][0].Jogada
                    },
                    new ModelJogadores
                    {
                        Jogador = jogadas[i + 1][0].Jogador,
                        Jogada = jogadas[i + 1][0].Jogada
                    }
                });               
            }

            return novaLista;
        }
    }
}

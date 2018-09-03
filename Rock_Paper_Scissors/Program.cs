using Rock_Paper_Scissors.Jogos;
using System.Collections.Generic;

namespace Rock_Paper_Scissors
{
    class Program
    {
        public static string msgErro = "";
        static void Main(string[] args)
        {
            new JogoUnico().partida(new List<ModelJogadores> {
                new ModelJogadores{Jogador =  "Armando", Jogada = "P"},
                new ModelJogadores{Jogador =  "Dave", Jogada = "S"},
            });

            new Torneio().rps_tournament_winner(new List<List<ModelJogadores>> {
                new List<ModelJogadores> {
                    new ModelJogadores {
                        Jogador = "Armando",
                        Jogada = "P"
                    },
                    new ModelJogadores {
                        Jogador = "Dave",
                        Jogada = "S"
                    }
                },
                new List<ModelJogadores> {
                    new ModelJogadores {
                        Jogador = "Richard",
                        Jogada = "R"
                    },
                    new ModelJogadores {
                        Jogador = "Michael",
                        Jogada = "S"
                    }
                },
                new List<ModelJogadores> {
                    new ModelJogadores {
                        Jogador = "Allen",
                        Jogada = "S"
                    },
                    new ModelJogadores {
                        Jogador = "Omer",
                        Jogada = "P"
                    }
                },
                new List<ModelJogadores> {
                    new ModelJogadores {
                        Jogador = "David E.",
                        Jogada = "R"
                    },
                    new ModelJogadores {
                        Jogador = "Richard X.",
                        Jogada = "P"
                    }
                }
            }, 0);
            
        }
    }
}

using System.Collections.Generic;

namespace Rock_Paper_Scissors.Util
{
    public class Validar
    {
        private readonly List<string> _jogadas;

        public Validar()
        {
            _jogadas = new List<string>
            {
                "R", "P", "S", "r", "p", "s"
            };
        }

        public void Validando(List<ModelJogadores> players)
        { 
            if (players.Count != 2)
                Program.msgErro = "Number of players must to be 2!";
            else
                foreach (var item in players)
                {
                    if (!_jogadas.Contains(item.Jogada))
                    {
                        Program.msgErro = string.Format("Moves must to be one of these {0}", string.Join(", ", _jogadas));
                        break;
                    }
                }            
        }
    }
}

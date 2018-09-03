namespace Rock_Paper_Scissors.Util
{
    public class StringSaida
    {
        public static string Format(ModelJogadores player)
        {
            return string.Format("[\"{0}\", \"{1}\"]", player.Jogador, player.Jogada);
        }
    }
}

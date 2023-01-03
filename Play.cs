namespace Oksana_Cherkas_Lr_1;

public class Play
{
    private List<GameAccount.Match> AllMatches = new List<GameAccount.Match>();
    private int GameCount = 0;
    public void start(GameAccount player1, GameAccount player2, double rate)
    {
        if (rate < 0)
        {
            throw new Exception("Rating < 0. You can't play game with negative rating");
        }

        if (player2.CurrentRating - rate > 0)
        {
            player1.WinGame(player2.UserName, rate, GameCount);
            player2.LoseGame(player1.UserName, rate, GameCount);
            AllMatches.Add(player1.MyMatches[^1]);
            GameCount = GameCount + 1;
        }
    }
    public List<GameAccount.Match> GetStats()
    {
        return AllMatches;
    }
}
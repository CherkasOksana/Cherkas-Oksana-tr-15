namespace Oksana_Cherkas_Lr_1;

public abstract class BasePlay
{
    public List<GameAccount.Match> AllMatches = new List<GameAccount.Match>();
    protected int GameCount = 0;
    public abstract void start(GameAccount player1, GameAccount player2, double rate);
    public List<GameAccount.Match> GetStats()
    {
        return AllMatches;
    }
}
public class Play : BasePlay
{
    public override void start(GameAccount player1, GameAccount player2, double rate)
    {
        if (rate < 0)
        {
            throw new Exception("Rating < 0. You can't play game with negative rating");
        }

        if (player2.CurrentRating - rate > 0)
        {
            AllMatches.Add(new GameAccount.Match(player1, player2, GameCount, rate));
            player1.WinGame(this);
            player2.LoseGame(this);
            
            GameCount = GameCount + 1;
        }
    }
}

public class LoseOnly : BasePlay
{
    public override void start(GameAccount player1, GameAccount player2, double rate)
    {
        if (rate < 0)
        {
            throw new Exception("Rating < 0. You can't play game with negative rating");
        }

        if (player2.CurrentRating - rate > 0)
        {
            AllMatches.Add(new GameAccount.Match(player1, player2, GameCount, 0));
            player1.WinGame(this);
            AllMatches[^1].rate = rate;
            player2.LoseGame(this);
            
            GameCount = GameCount + 1;
        }
    }
}

public class WinOnly : BasePlay
{
    public override void start(GameAccount player1, GameAccount player2, double rate)
    {
        if (rate < 0)
        {
            throw new Exception("Rating < 0. You can't play game with negative rating");
        }

        if (player2.CurrentRating - rate > 0)
        {
            AllMatches.Add(new GameAccount.Match(player1, player2, GameCount, rate));
            player1.WinGame(this);
            AllMatches[^1].rate = 0;
            player2.LoseGame(this);
            AllMatches[^1].rate = rate;
            
            GameCount = GameCount + 1;
        }
    }
}

public class NoRating : BasePlay
{
    public override void start(GameAccount player1, GameAccount player2, double rate)
    {
        if (rate < 0)
        {
            throw new Exception("Rating < 0. You can't play game with negative rating");
        }

        if (player2.CurrentRating - rate > 0)
        {
            AllMatches.Add(new GameAccount.Match(player1, player2, GameCount, 0));
            player1.WinGame(this);
            player2.LoseGame(this);
            
            GameCount = GameCount + 1;
        }
    }
}
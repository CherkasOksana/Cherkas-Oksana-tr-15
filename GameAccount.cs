namespace Oksana_Cherkas_Lr_1;

public class GameAccount
{
    public class Match
    {
        public GameAccount winner;
        public GameAccount loser;
        public int GamesCount;
        public double rate;

        public Match(GameAccount winner, GameAccount loser, int GamesCount, double rate)
        {
            this.winner = winner;
            this.loser = loser;
            this.GamesCount = GamesCount;
            this.rate = rate;
        }
    }
    
    public string UserName = "No name";
    public double CurrentRating;

    public List<Match> MyMatches = new List<Match>();

    public GameAccount(string UserName, double CurrentRating)
    {
        this.UserName = UserName;
        this.CurrentRating = CurrentRating;
    }
    
    public GameAccount(double CurrentRating)
    {
        this.CurrentRating = CurrentRating;
    }

    public virtual void WinGame(BasePlay play)
    {
        CurrentRating = CurrentRating + play.AllMatches[^1].rate;
        MyMatches.Add(new Match(play.AllMatches[^1].winner, play.AllMatches[^1].loser, play.AllMatches[^1].GamesCount, play.AllMatches[^1].rate));
    }
    
    public virtual void LoseGame(BasePlay play)
    {
        CurrentRating = CurrentRating - play.AllMatches[^1].rate;
        MyMatches.Add(new Match(play.AllMatches[^1].winner, play.AllMatches[^1].loser, play.AllMatches[^1].GamesCount, play.AllMatches[^1].rate));
    }

    public List<Match> GetStats()
    {
        return MyMatches;
    }
}

public class DoubleRating : GameAccount
{
    public DoubleRating(string UserName, double CurrentRating) : base(UserName, CurrentRating)
    {
        this.UserName = UserName;
        this.CurrentRating = CurrentRating;
    }
    public DoubleRating(double CurrentRating) : base(CurrentRating)
    {
        this.CurrentRating = CurrentRating;
    }
    public override void WinGame(BasePlay play)
    {
        CurrentRating = CurrentRating + 2 * play.AllMatches[^1].rate;
        MyMatches.Add(new Match(play.AllMatches[^1].winner, play.AllMatches[^1].loser, play.AllMatches[^1].GamesCount, 2 * play.AllMatches[^1].rate));
    }
    
    public override void LoseGame(BasePlay play)
    {
        CurrentRating = CurrentRating - 2 * play.AllMatches[^1].rate;
        MyMatches.Add(new Match(play.AllMatches[^1].winner, play.AllMatches[^1].loser, play.AllMatches[^1].GamesCount, 2 * play.AllMatches[^1].rate));
    }
}

public class HalfRating : GameAccount
{
    public HalfRating(string UserName, double CurrentRating) : base(UserName, CurrentRating)
    {
        this.UserName = UserName;
        this.CurrentRating = CurrentRating;
    }
    public HalfRating(double CurrentRating) : base(CurrentRating)
    {
        this.CurrentRating = CurrentRating;
    }
    public override void WinGame(BasePlay play)
    {
        CurrentRating = CurrentRating + play.AllMatches[^1].rate/2;
        MyMatches.Add(new Match(play.AllMatches[^1].winner, play.AllMatches[^1].loser, play.AllMatches[^1].GamesCount, play.AllMatches[^1].rate/2));
    }
    
    public override void LoseGame(BasePlay play)
    {
        CurrentRating = CurrentRating - play.AllMatches[^1].rate/2;
        MyMatches.Add(new Match(play.AllMatches[^1].winner, play.AllMatches[^1].loser, play.AllMatches[^1].GamesCount, play.AllMatches[^1].rate/2));
    }
}
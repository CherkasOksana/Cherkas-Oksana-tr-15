namespace Oksana_Cherkas_Lr_1;

public class GameAccount
{
    public class Match
    {
        public double rate;
        public int GamesCount;
        public string WinnerName;
        public string LoserName;

        public Match(double rate, int GamesCount, string WinnerName, string LoserName)
        {
            this.rate = rate;
            this.GamesCount = GamesCount;
            this.WinnerName = WinnerName;
            this.LoserName = LoserName;
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

    public void WinGame(string opponentName, double Rating, int GameCount)
    {
        CurrentRating = CurrentRating + Rating;
        MyMatches.Add(new Match(Rating, GameCount, UserName, opponentName));
    }
    
    public void LoseGame(string opponentName, double Rating, int GameCount)
    {
        CurrentRating = CurrentRating - Rating;
        MyMatches.Add(new Match(Rating, GameCount, opponentName, UserName));
    }

    public List<Match> GetStats()
    {
        return MyMatches;
    }
}
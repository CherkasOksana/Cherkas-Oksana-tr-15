using Oksana_Cherkas_Lr_1;

namespace Oksana_Cherkas_Lr
{
    class Program
    {
        static void Main()
        {
            GameAccount me = new HalfRating("Me", 200);
            GameAccount opponent = new DoubleRating("Opponent",200);

            PlayModes modes = new PlayModes();
            var play = modes.LoseOnly();
            play.start(me, opponent, 20);
            play.start(me, opponent, 15);
            play.start(opponent, me, 5);
            play.start(opponent, me, 20);
            play.start(opponent, me, 25);
            
            //play.start(me, opponent, -1); // test error

            var MyStats = me.GetStats();
            Console.WriteLine("\nMy Stats");
            for (int i = 0; i < MyStats.Count; i++)
            {
                Console.WriteLine("{0}: {1} - win; {2} - lose; rate = {3}", MyStats[i].GamesCount, MyStats[i].winner.UserName, MyStats[i].loser.UserName, MyStats[i].rate);
            }
            Console.WriteLine("\nMy current rating = {0}", me.CurrentRating);
            
            
            var OpponentStats = opponent.GetStats();
            Console.WriteLine("\nOpponent Stats");
            for (int i = 0; i < OpponentStats.Count; i++)
            {
                Console.WriteLine("{0}: {1} - win; {2} - lose; rate = {3}", OpponentStats[i].GamesCount, OpponentStats[i].winner.UserName, OpponentStats[i].loser.UserName, OpponentStats[i].rate);
            }
            Console.WriteLine("\nOpponent current rating = {0}", opponent.CurrentRating);

            var stats = play.GetStats();
            Console.WriteLine("\nStats");
            for (int i = 0; i < stats.Count; i++)
            {
                Console.WriteLine("{0}: {1} - win; {2} - lose; rate = {3}", stats[i].GamesCount, stats[i].winner.UserName, stats[i].loser.UserName, stats[i].rate);
            }
        }
    }
}

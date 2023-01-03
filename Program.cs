using Oksana_Cherkas_Lr_1;

namespace Oksana_Cherkas_Lr
{
    class Program
    {
        static void Main()
        {
            GameAccount me = new GameAccount("Me", 200);
            GameAccount opponent = new GameAccount("Opponent", 200);

            Play play = new Play();
            play.start(me, opponent, 20);
            play.start(me, opponent, 15);
            play.start(opponent, me, 5);
            play.start(opponent, me, 20);
            play.start(opponent, me, 20);
            
            //play.start(me, opponent, -1); // test error

            var MyStats = me.GetStats();
            Console.WriteLine("\nMy Stats");
            for (int i = 0; i < MyStats.Count; i++)
            {
                Console.WriteLine("{0}: {1} - win; {2} - lose; rate = {3}; my current rate: ", MyStats[i].GamesCount, MyStats[i].WinnerName, MyStats[i].LoserName, MyStats[i].rate);
            }
            Console.WriteLine("\nMy current rating = {0}", me.CurrentRating);
            
            
            var OpponentStats = opponent.GetStats();
            Console.WriteLine("\nOpponent Stats");
            for (int i = 0; i < OpponentStats.Count; i++)
            {
                Console.WriteLine("{0}: {1} - win; {2} - lose; rate = {3}", OpponentStats[i].GamesCount, OpponentStats[i].WinnerName, OpponentStats[i].LoserName, OpponentStats[i].rate);
            }
            Console.WriteLine("\nOpponent current rating = {0}", opponent.CurrentRating);


            var stats = play.GetStats();
            Console.WriteLine("\nStats");
            for (int i = 0; i < stats.Count; i++)
            {
                Console.WriteLine("{0}: {1} - win; {2} - lose; rate = {3}", stats[i].GamesCount, stats[i].WinnerName, stats[i].LoserName, stats[i].rate);
            }
        }
    }
}

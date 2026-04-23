using System;

namespace PlayerStats
{
    public class Program
    {
        private static void Main()
        {
            Player[] players = {
                new Player("Ana"),
                new Player("Zé"),
                new Player("Doesn't play")
            };

            players[0].PlayGame(false);
            players[0].PlayGame(true);
            players[0].PlayGame(true);
            players[0].PlayGame(false);
            players[0].PlayGame(false);
            players[0].PlayGame(true);
            players[0].HighScore = 123;
            players[0].HighScore = 40;

            players[1].PlayGame(true);
            players[1].PlayGame(true);
            players[1].HighScore = 12;
            players[1].HighScore = 67;
            players[1].HighScore = 91;
            players[1].HighScore = 32;

            foreach (Player player in players)
            {
                Console.WriteLine($" Player name : {player.Name}");
                Console.WriteLine($"    Win rate : {player.WinRate}");
                Console.WriteLine($"  High score : {player.HighScore}");
                Console.WriteLine("--------------------------------");
            }

            // Output deve ser:
            //
            //  Player name : Ana
            //     Win rate : 0.5
            //   High score : 123
            // --------------------------------
            //  Player name : Zé
            //     Win rate : 1
            //   High score : 91
            // --------------------------------
            //  Player name : Doesn't play
            //     Win rate : 0
            //   High score : 0
            // --------------------------------

        }
    }

    public class Player
    {
        private float _highscore;
        private int _playedGames;
        private int _wonGames;
    

        public Player()

        {
            Name = "Pedro";

            //Console.Write("Enter player name: ");

            //Name = Console.ReadLine() ?? "Unknown";

        }

        public Player(string name)
        {
            Name = name;
        }

    

    public float HighScore
        //{
            //float highscore = 0;
            //if (highscore < _highscore)
            //{
            //    highscore += _highscore;
            //}
            
        {
            get => _highscore;
            set
            {
                if (value > _highscore)
                {
                    _highscore = value;
                }
            }
        }
        //}


    public string Name { get; }
    public float WinRate => _playedGames == 0 ? 0f : (float)_wonGames / _playedGames;

    public void PlayGame(bool win)

    {

        _playedGames++;

        if (win)

        {

            _wonGames++;

        }

    }

    }

    
}

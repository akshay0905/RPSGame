using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    class Match : IMatch
    {
        public int numberOfGames { get; set; }
        public IGame game { get; set; }
        public int userWon = 0;
        public int botWon = 0;

        public Match(IGame _game)
        {
            game = _game;
        }

        public void ConfigureMatch()
        {
            List<IPlayer> players = new List<IPlayer>() {
                new UserPlayer(),
                new BotPlayer()
            };

            game.players = players;
        }
        
        public void RunMatch()
        {
            IPlayer winner;
           
            while (numberOfGames > 0)
            {
                game.RunGame();

                winner = game.GetWinner();

                if (winner != null && winner is UserPlayer)
                {
                    userWon++;
                }
                else
                {
                    botWon++;
                }

                numberOfGames--;
            }
        }

        public bool isuserWon()
        {
            if (userWon > botWon)
            {
                return true;
            }

            return false;
        }
    }
}

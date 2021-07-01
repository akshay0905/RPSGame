using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    class RPSGame : IGame
    {
        public List<IPlayer> players { get; set; }

        public RPSGame()
        {

        }

        public RPSGame(List<IPlayer> _players)
        {
            players = _players;
        }

        public void RunGame()
        {
            players.ForEach(player =>
            {
                player.Play();
            });
        }

        public IPlayer GetWinner()
        {
            IPlayer winner = CalculateWinner();
            return winner;
        }

        private IPlayer? CalculateWinner()
        {
            //Assuming that there is one and only one user player. If there are multiple user players then this code will be modified
            var userPlayer = players.Where(x => x is UserPlayer).FirstOrDefault();
            if (userPlayer != null)
            {
                var botPlayers = players.Where(x => x is BotPlayer)?.ToList();

                if (botPlayers == null || !botPlayers.Any())
                {
                    return userPlayer;
                }

                if (userPlayer.selectedOption == Options.Rock && !botPlayers.Any(x => x.selectedOption == Options.Paper))
                {
                    return userPlayer;
                }

                if (userPlayer.selectedOption == Options.Paper && !botPlayers.Any(x => x.selectedOption == Options.Scissors))
                {
                    return userPlayer;
                }

                if (userPlayer.selectedOption == Options.Scissors && !botPlayers.Any(x => x.selectedOption == Options.Rock))
                {
                    return userPlayer;
                }

                return botPlayers.FirstOrDefault();
            }

            return null;
        }
    }
}

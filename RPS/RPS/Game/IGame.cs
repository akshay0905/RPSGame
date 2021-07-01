using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    /// <summary>
    /// Game Interface.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public List<IPlayer> players { get; set; }

        /// <summary>
        /// Runs the game.
        /// </summary>
        public void RunGame();

        /// <summary>
        /// Gets the winner.
        /// </summary>
        /// <returns></returns>
        public IPlayer GetWinner();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    /// <summary>
    /// Bot.
    /// </summary>
    /// <seealso cref="RPS.IPlayer" />
    class BotPlayer : IPlayer
    {
        /// <summary>
        /// Gets or sets the selected option.
        /// </summary>
        /// <value>
        /// The selected option.
        /// </value>
        public Options? selectedOption { get; set; }

        /// <summary>
        /// Plays this instance.
        /// </summary>
        public void Play()
        {
            var random = new Random();
            int number = random.Next(1, 3);

            if (number == 1)
            {
                selectedOption = Options.Rock;
            }

            if (number == 2)
            {
                selectedOption = Options.Paper;
            }

            if (number == 3)
            {
                selectedOption = Options.Scissors;
            }

            Console.WriteLine("Bot Chose:" + selectedOption.ToString());
        }
    }
}

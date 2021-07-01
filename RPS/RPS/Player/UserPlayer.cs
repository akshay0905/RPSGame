using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    /// <summary>
    /// User.
    /// </summary>
    /// <seealso cref="RPS.IPlayer" />
    class UserPlayer : IPlayer
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
            Console.WriteLine("Please choose your option: ");
            Console.WriteLine("R: Rock");
            Console.WriteLine("P: Paper");
            Console.WriteLine("S: Scissor");

            char selected = Console.ReadKey().KeyChar;

            selectedOption = GetOption(selected);

            Console.WriteLine("You Chose:" + selectedOption.ToString());
        }

        /// <summary>
        /// Gets the option.
        /// </summary>
        /// <param name="selectedOption">The selected option.</param>
        /// <returns></returns>
        private static Options? GetOption(char selectedOption)
        {
            if (selectedOption == 'R' || selectedOption == 'r')
                return Options.Rock;
            if (selectedOption == 'P' || selectedOption == 'p')
                return Options.Paper;
            if (selectedOption == 'S' || selectedOption == 's')
                return Options.Scissors;

            return null;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    /// <summary>
    /// Player.
    /// </summary>
    public interface IPlayer
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
        public void Play();
    }
}

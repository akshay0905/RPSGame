using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    public interface IMatch
    {
        public int numberOfGames { get; set; }
        public IGame game { get; set; }
        public void ConfigureMatch();
        public void RunMatch();

        public bool isuserWon();
    }
}

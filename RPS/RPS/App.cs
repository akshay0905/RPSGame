using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    class App
    {
        private readonly IConfiguration _config;
        private IMatch _match;

        public App(IConfiguration config, IMatch match)
        {
            _config = config;
            _match = match;
        }
        public void Run()
        {
            _match.numberOfGames = 3;

            _match.ConfigureMatch();
            _match.RunMatch();

            if (_match.isuserWon())
            {
                Console.WriteLine("YOU WON!!!");
            }
            else
            {
                Console.WriteLine("BOT WON!!! YOU LOST!!");
            }
        }
    }
}

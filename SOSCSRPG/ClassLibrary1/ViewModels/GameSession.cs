using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.PlayerModels;

namespace ClassLibrary1.ViewModels
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Alex";
            CurrentPlayer.Gold = 100000;
        }
    }
}

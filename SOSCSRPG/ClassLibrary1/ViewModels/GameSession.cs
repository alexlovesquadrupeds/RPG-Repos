using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.PlayerModels;
using ClassLibrary1.Factories;

namespace ClassLibrary1.ViewModels
{
    public class GameSession
    {      
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Alex";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.CharacterClass = "Mage";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = 0;
            CurrentLocation.Description = "This is your house. Get up!";
            CurrentLocation.ImageName = "/ClassLibrary1;component/Images/Locations/home.png";

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

        }
    }
}

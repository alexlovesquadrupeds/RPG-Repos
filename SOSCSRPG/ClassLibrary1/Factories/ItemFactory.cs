using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.PlayerModels;

namespace ClassLibrary1.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            _standardGameItems.Add(new Weapon(1001, "Kokiri Sword", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Master Sword", 5, 1, 3));
            _standardGameItems.Add(new GameItem(9001, "Deku Stick", 1));
            _standardGameItems.Add(new GameItem(9002, "Deku Nuts", 2));
            _standardGameItems.Add(new GameItem(9003, "Parasitic Tentacle", 1));
            _standardGameItems.Add(new GameItem(9004, "Bari", 2));
            _standardGameItems.Add(new GameItem(9005, "Triforce of Power", 1));
            _standardGameItems.Add(new GameItem(9006, "Triforce of Wisdom and the Triforce of Courage", 2));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if(standardItem != null)
                {
                    if (standardItem is Weapon)
                    {
                        return (standardItem as Weapon).Clone();
                    }

                return standardItem.Clone();
                }

            return null;
        }
    }
}

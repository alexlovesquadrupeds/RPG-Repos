using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.PlayerModels;

namespace ClassLibrary1.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();

        static TraderFactory()
        {
            Trader skullKid = new Trader("Skull Kid");
            skullKid.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader kodeeQ = new Trader("Kodee Q");
            kodeeQ.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader peterPeterPumpkinEater = new Trader("Peter Peter the Pumpkin Eater");
            peterPeterPumpkinEater.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            AddTraderToList(skullKid);
            AddTraderToList(kodeeQ);
            AddTraderToList(peterPeterPumpkinEater);
        }

        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }

        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }

            _traders.Add(trader);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.PlayerModels;

namespace ClassLibrary1.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster Deku_Baba =
                        new Monster("Deku Baba", "dekubaba.png", 4, 4, 5, 1);

                    AddLootItem(Deku_Baba, 9001, 25);
                    AddLootItem(Deku_Baba, 9002, 75);

                    return Deku_Baba;

                case 2:
                    Monster Jabu_Jabu =
                        new Monster("Jabu Jabu", "jabujabu.jpg", 5, 5, 5, 1);

                    AddLootItem(Jabu_Jabu, 9003, 25);
                    AddLootItem(Jabu_Jabu, 9004, 75);

                    return Jabu_Jabu;

                case 3:
                    Monster Ganondorf =
                        new Monster("Ganondorf", "ganondorf.png", 10, 10, 10, 3);

                    AddLootItem(Ganondorf, 9005, 33);
                    AddLootItem(Ganondorf, 9006, 67);

                    return Ganondorf;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }

    }
}

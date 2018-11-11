using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PlayerModels
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            // Declare the items need to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9002, 3));
            rewardItems.Add(new ItemQuantity(1002, 1));

            // Create the quest
            _quests.Add(new Quest(1,
                                  "Clear the Lost Woods",
                                  "Defeat the Deku Baba in the Lost Woods",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
            /*
            // Declare the items need to complete the SECOND quest, and its reward items
            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9002, 3));
            rewardItems.Add(new ItemQuantity(1002, 1));
            _quests.Add(new Quest(2,
                      "Defeat Jabu Jabu",
                      "Defeat the Deku Baba in the Lost Woods",
                      itemsToComplete,
                      25, 10,
                      rewardItems));
                */
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }

    }
}

﻿using System;
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

            // second quest - defeat jabu and bring me his insides
            _quests.Add(new Quest(2,
                                "Bring me Jabu-Jabu's insides",
                                "Bring me some yummy tentacles",
                                new List { new ItemQuantity(9003, 2) },
                                25, 10,
                                new List { new ItemQuantity(1001, 1) }));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }

    }

    internal class List : List<ItemQuantity>
    {
    }
}

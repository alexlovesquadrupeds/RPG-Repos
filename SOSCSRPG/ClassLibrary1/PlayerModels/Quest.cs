using System.Collections.Generic;

namespace ClassLibrary1.PlayerModels
{
    public class Quest
    {
        private readonly int v1;
        private readonly string v2;
        private readonly string v3;
        private readonly List<object> list;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ItemQuantity> ItemsToComplete { get; set; }

        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }

        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete,
                     int rewardExperiencePoints, int rewardGold, List<ItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }

        public Quest(int v1, string v2, List<object> list1, int v3, int v4, List<object> list2)
        {
        }

        public Quest(int v1, string v2, string v3, List<object> list)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.list = list;
        }
    }
}

using ClassLibrary1.PlayerModels;

namespace ClassLibrary1.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, 0, "The Great Deku Tree",
                "The Great Deku Tree is sad. You sense that something is wrong...",
                "deku.png");

            newWorld.LocationAt(-2, 0).AddMonster(1, 100);

            newWorld.AddLocation(-1, 0, "The Lost Woods",
                "Welcome. Try not to get lost",
                "lostWoods.jpg");

            newWorld.LocationAt(-1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 0, "Home",
                "This is your house. Get up!",
                "home.png");

            newWorld.AddLocation(-1, 1, "Kokiri Forest",
                "You head to the Kokiri Store. Purveyors of fine goods.",
                "kokiri.png");
            newWorld.LocationAt(-1, 1).TraderHere =
                TraderFactory.GetTraderByName("Skull Kid");

            newWorld.AddLocation(0, 1, "Hyrule Field",
                "You see the open plains of Hyrule Field",
                "lostWoods.jpg");

            newWorld.AddLocation(1, 1, "Zora's River",
                "This beautiful stream leads to Zora's domain",
                "zorasRiver.png");
            newWorld.LocationAt(1, 1).TraderHere =
                TraderFactory.GetTraderByName("Peter Peter the Pumpkin Eater");

            newWorld.AddLocation(2, 1, "Zora's Domain",
                "Home to the Zora family and Lord Jabu-Jabu",
                "zoraDomain.png");

            newWorld.LocationAt(2, 1).AddMonster(2, 100);

            newWorld.AddLocation(0, 2, "Castle Town",
                "The main hub and center of activity in the Kingdom, where Hyruleans come to engage in business and trade goods.",
                "castleTown.jpg");

            //newWorld.LocationAt(0, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            newWorld.AddLocation(0, 3, "Hyrule Castle",
                "The home of the Princess Zelda and the Royal Family of Hyrule",
                "hyruleCastle.jpg");

            newWorld.LocationAt(0, 3).AddMonster(3, 100);


            return newWorld;

        }
    }
}

using ZorksRevenge.MiniGames;
using ZorksRevenge.Utility;


namespace ZorksRevenge
{
    public class FinalBoss : MiniGame
    {
        public override bool Play()
        {
            Console.Clear();

            BattleData.Initialize();

            ZorkPrinter.Print("\"Hehe, thank you for all the 7 gems\" says ");
            ZorkPrinter.PrintLine("Zork", ZorkPrinter.NPCColour);
            ZorkPrinter.PrintLine("\"Thanks to you and the power of the 7 games my plan for world domination is at hand\"");
            ZorkPrinter.PrintLine("\"hahahahahahahaha\"");
            ZorkPrinter.PrintLine("\"I will kill you now...\"\n\n");

            ZorkPrinter.PrintLine("Out of the shadows jumps two Pokemon Ninjas!");
            ZorkPrinter.PrintLine("Jono and Beastcilla", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine("\"You can count on us for help!\"\n");

            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            ZorkPrinter.PrintLine("Minigame #8 Final Battle");
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");

            BeginBattle();

            return false;
        }

        private void BeginBattle()
        {
            bool isLooping = true; 
            
            ZorkPrinter.PrintLine("");

            ZorkPrinter.PrintLine($"{Player.Name}'s HP: {BattleData.PlayerHP} / 100", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine($"Zork's HP: {BattleData.EnemyHP} / 100\n", ZorkPrinter.NPCColour);

            while (isLooping)
            {
                ZorkPrinter.PrintLine($"{BattleData.CurTrainer.Name} releases {BattleData.CurPokemon.Name}! ", ZorkPrinter.PlayerColour);

                int i = 1;
                foreach (Move m in BattleData.CurPokemon.Moves)
                {
                    ZorkPrinter.PrintLine($"    ({i}) {m.Name}");
                    i++;
                }

                ZorkPrinter.Print("\n:> ");
                string input = Console.ReadLine();
                Console.Clear();

                if (int.TryParse(input, out int option))
                {
                    if (option == 1 ||
                        option == 2 ||
                        option == 3 ||
                        option == 4)
                    {

                        BattleData.CurPokemon.Action(option);

                        BattleData.EnemyTurn();

                        BattleData.UpdateTrainer();

                        ZorkPrinter.PrintLine("");

                        ZorkPrinter.PrintLine($"{Player.Name}'s HP: {BattleData.PlayerHP} / 100", ZorkPrinter.PlayerColour);
                        ZorkPrinter.PrintLine($"Zork's HP: {BattleData.EnemyHP} / 100\n", ZorkPrinter.NPCColour);

                        if (BattleData.EnemyHP <= 0)
                        {
                            Player.DidBeatGame = true;
                            ZorkPrinter.PrintEnd();
                        }
                        else if (BattleData.PlayerHP <= 0)
                        {
                            isLooping = false;
                        }
                    }
                }
            }
        }
    }
}

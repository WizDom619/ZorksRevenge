using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.MiniGames.FinalBoss
{
    /// <summary>
    /// Final Boss the the last MiniGame the player will play. 
    /// The idea is a mock Pokemon battle with the final boss Zork. 
    /// Player will rotate between six Pokemons with unique moves to damage Zork. 
    /// The battle is pretty easy, figured I'd finish of a dopamine high. 
    /// </summary>
    public class FinalBoss : MiniGame
    {
        public override bool Play(GameData gameData)
        {
            ZorkPrinter.ClearScreen();

            // Reset all values. 
            BattleData.Init();

            // Some flavour text to preempt the battle. 
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

            BeginBattle(gameData);

            return false;
        }

        private void BeginBattle(GameData gameData)
        {
            // The battle will keep going until isLooping is false. 
            bool isLooping = true; 
            
            ZorkPrinter.PrintLine("");

            ZorkPrinter.PrintLine($"{gameData.Player.Name}'s HP: {BattleData.PlayerHP} / 100", ZorkPrinter.PlayerColour);
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

                        ZorkPrinter.PrintLine($"{gameData.Player.Name}'s HP: {BattleData.PlayerHP} / 100", ZorkPrinter.PlayerColour);
                        ZorkPrinter.PrintLine($"Zork's HP: {BattleData.EnemyHP} / 100\n", ZorkPrinter.NPCColour);

                        if (BattleData.EnemyHP <= 0)
                        {
                            gameData.Player.DidBeatGame = true;
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

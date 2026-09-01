using ZorksRevenge.Utility;

namespace ZorksRevenge.MiniGames
{
    /// <summary>
    /// This MiniGame is fairly easy as the player must win only 3 while the computer must win 5. 
    /// There's not skill it's a total game of chance. 
    /// </summary>
    public class RockPaperScissors : MiniGame
    {
        public override bool Play()
        {
            const int CPUGOAL = 5;
            const int PLAYERGOAL = 3;

            const string ROCK = "ROCK";
            const string PAPER = "PAPER";
            const string SCISSORS = "SCISSORS";
            
            bool result = false;
            bool isPlaying = true;

            int cpuWins = 0;
            int playerWins = 0;

            Random random = new Random();
            string answer = "";

            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            ZorkPrinter.PrintLine("Minigame #2 Rock, Paper Scissors");
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");

            ZorkPrinter.Print("Please win ");
            ZorkPrinter.Print($"x{PLAYERGOAL} ", ZorkPrinter.PlayerColour);
            ZorkPrinter.Print("times, I will try to win ");
            ZorkPrinter.Print($"x{CPUGOAL} ", ZorkPrinter.NPCColour);
            ZorkPrinter.PrintLine($"times\n");

            while (isPlaying)
            {
                ZorkPrinter.PrintLine($"Sphinx: x{cpuWins}", ZorkPrinter.NPCColour);
                ZorkPrinter.PrintLine($"Player: x{playerWins}\n", ZorkPrinter.PlayerColour);
                ZorkPrinter.Print(":> ");

                string? guess = Console.ReadLine();

                if (guess == null)
                {
                    continue;
                }

                // To avoid confusion around capitalisation, all words will be in uppercase
                guess = guess.ToUpperInvariant();

                ZorkPrinter.PrintLine($"");

                // Validate input
                if (guess != ROCK &&
                    guess != PAPER &&
                    guess != SCISSORS)
                {
                    ZorkPrinter.PrintLine("That's not a valid input");
                    continue;
                }

                // Process Input
                switch (random.Next(1, 4))
                {
                    case 1:
                        answer = ROCK;
                        break;
                    case 2:
                        answer = PAPER;
                        break;
                    case 3:
                        answer = SCISSORS;
                        break;
                }

                ZorkPrinter.PrintLine($"Player! --- Sphinx! ");
                ZorkPrinter.PrintLine($" {guess}      {answer}");

                // Determine who wins. 
                switch (guess) 
                {
                    case ROCK:
                        ZorkPrinter.Print("        ");
                        if (answer == ROCK)
                        {
                            ZorkPrinter.PrintLine("It's a draw!");
                            ZorkPrinter.Print("          ");
                        }
                        else if (answer == PAPER)
                        {
                            ZorkPrinter.PrintLine("+1 to Sphinx!");
                            cpuWins++;
                        }
                        else
                        {
                            ZorkPrinter.PrintLine("+1 to Player");
                            playerWins++;
                        }
                        ZorkPrinter.PrintLine("");
                        break;

                    case PAPER:
                        ZorkPrinter.Print("          ");
                        if (answer == ROCK)
                        {
                            ZorkPrinter.PrintLine("+1 to Player");
                            playerWins++;
                        }
                        else if (answer == PAPER)
                        {
                            ZorkPrinter.PrintLine("It's a draw!");
                        }
                        else
                        {
                            ZorkPrinter.PrintLine("+1 to Sphinx!");
                            cpuWins++;
                        }
                        ZorkPrinter.PrintLine("");
                        break;

                    case SCISSORS:
                        ZorkPrinter.Print("          ");
                        if (answer == ROCK)
                        {
                            ZorkPrinter.PrintLine("+1 to Sphinx!");
                            cpuWins++;
                        }
                        else if (answer == PAPER)
                        {
                            ZorkPrinter.PrintLine("+1 to Player");
                            playerWins++;
                        }
                        else
                        {
                            ZorkPrinter.PrintLine("It's a draw!");
                        }
                        break;
                }
                ZorkPrinter.PrintLine("-----------------------------\n");                   
                
                // Process the round's outcome. 
                if (cpuWins == CPUGOAL)
                {
                    isPlaying = false;
                    ZorkPrinter.PrintLine("You lose!\n");
                }
                else if (playerWins == PLAYERGOAL)
                {
                    isPlaying = false;
                    result = true;
                    ZorkPrinter.PrintLine("You win!\n");
                }
            }

            return result;
        }
    }
}

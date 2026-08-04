using System.Collections;

namespace ZorksRevenge.MiniGames
{
    public class RockPaperScissors : MiniGame
    {
        public override bool Play()
        {
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
            ZorkPrinter.Print("x3 ", ZorkPrinter.PlayerColour);
            ZorkPrinter.Print("times, I will try to win ");
            ZorkPrinter.Print("x5 ", ZorkPrinter.NPCColour);
            ZorkPrinter.PrintLine($"times\n");

            while (isPlaying)
            {
                ZorkPrinter.PrintLine($"Sphinx: x{cpuWins}", ZorkPrinter.NPCColour);
                ZorkPrinter.PrintLine($"Player: x{playerWins}\n", ZorkPrinter.PlayerColour);
                ZorkPrinter.Print(":> ");

                string guess = Console.ReadLine();

                ZorkPrinter.PrintLine($"");

                if (guess.ToUpper() != "ROCK" &&
                    guess.ToUpper() != "PAPER" &&
                    guess.ToUpper() != "SCISSORS")
                {
                    ZorkPrinter.PrintLine("That's not a valid input");
                    continue;
                }
                else
                {
                    switch (random.Next(1, 4))
                    {
                        case 1:
                            answer = "ROCK";
                            break;
                        case 2:
                            answer = "PAPER";
                            break;
                        case 3:
                            answer = "SCISSORS";
                            break;
                    }

                    ZorkPrinter.PrintLine($"Player! --- Sphinx! ");
                    ZorkPrinter.PrintLine($" {guess.ToUpper()}      {answer}");

                    switch (guess.ToUpper()) 
                    {
                        case "ROCK":
                            ZorkPrinter.Print("        ");
                            if (answer == "ROCK")
                            {
                                ZorkPrinter.PrintLine("It's a draw!");
                                ZorkPrinter.Print("          ");
                            }
                            else if (answer == "PAPER")
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

                        case "PAPER":
                            ZorkPrinter.Print("          ");
                            if (answer == "ROCK")
                            {
                                ZorkPrinter.PrintLine("+1 to Player");
                                playerWins++;
                            }
                            else if (answer == "PAPER")
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

                        case "SCISSORS":
                            ZorkPrinter.Print("          ");
                            if (answer == "ROCK")
                            {
                                ZorkPrinter.PrintLine("+1 to Sphinx!");
                                cpuWins++;
                            }
                            else if (answer == "PAPER")
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
                }   
                
                if (cpuWins == 5)
                {
                    isPlaying = false;
                    ZorkPrinter.PrintLine("You lose!\n");
                }
                else if (playerWins == 3)
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

using System.Collections;

namespace ZorksRevenge.MiniGames
{
    internal class RockPaperScissors : MiniGame
    {
        public override bool Play()
        {
            bool result = false;
            bool isPlaying = true;

            int cpuWins = 0;
            int playerWins = 0;

            Random random = new Random();
            string answer = "";

            ZorkPrinter.PrintLine("Let's play Rock, Paper Scissors");
            ZorkPrinter.PrintLine("Please win x3 times, I will try to win x5 times\n");

            while (isPlaying)
            {
                ZorkPrinter.PrintLine($"Sphinx win's: {cpuWins}");
                ZorkPrinter.PrintLine($"Player win's: {playerWins}\n");
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

                    ZorkPrinter.PrintLine($"Player: {guess}    Sphinx: {answer}");

                    switch (guess.ToUpper()) 
                    {
                        case "ROCK":
                            if (answer == "ROCK")
                            {
                                ZorkPrinter.PrintLine("It's a draw!");
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
                            break;

                        case "SCISSORS":
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
                }   
                
                if (cpuWins == 5)
                {
                    isPlaying = false;
                    ZorkPrinter.PrintLine("You lose!");
                }
                else if (playerWins == 3)
                {
                    isPlaying = false;
                    result = true;
                    ZorkPrinter.PrintLine("You win!");
                }
            }

            return result;
        }
    }
}

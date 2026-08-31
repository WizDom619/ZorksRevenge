using ZorksRevenge.Utility;

namespace ZorksRevenge.MiniGames
{
    internal class Quiz : MiniGame
    {
        public override bool Play()
        {
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            ZorkPrinter.PrintLine("Minigame #7 Intelligence Quiz");
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");

            bool isLooping1 = true;
            int currentQuestion = 1;

            while (isLooping1)
            {
                if (currentQuestion == 1)
                {
                    ZorkPrinter.Print($"Question 1: ");
                    ZorkPrinter.Print($"  Is "); 
                    ZorkPrinter.Print($"Acting ", ConsoleColor.Gray, PrintEffect.Italic);
                    ZorkPrinter.PrintLine($"Easy?");

                    ZorkPrinter.PrintLine("  (1) No — it demands emotional control, physical discipline, and intense focus ");
                    ZorkPrinter.PrintLine("  (2) Yes, you just have to remember your lines and not look at the camera");
                    ZorkPrinter.PrintLine("  (3) Only if you're already professionally trained");
                    ZorkPrinter.PrintLine("  (4) No, but only because the paparazzi make it hard\n");
                }
                else if (currentQuestion == 2)
                {
                    ZorkPrinter.Print($"Question 2: ");
                    ZorkPrinter.Print($"  What ");
                    ZorkPrinter.Print($"Flavour ", ConsoleColor.Gray, PrintEffect.Italic);
                    ZorkPrinter.PrintLine($"is the grossest thing on the Planet?");

                    ZorkPrinter.PrintLine("  (1) Mayonnaise");
                    ZorkPrinter.PrintLine("  (2) Cinnamon");
                    ZorkPrinter.PrintLine("  (3) Mint");
                    ZorkPrinter.PrintLine("  (4) Coriander\n");
                }
                else if (currentQuestion == 3) 
                {
                    ZorkPrinter.Print($"Question 3: ");
                    ZorkPrinter.Print($"  What is the ");
                    ZorkPrinter.Print($"Coolest ", ConsoleColor.Gray, PrintEffect.Italic);
                    ZorkPrinter.PrintLine($"Colour?");

                    ZorkPrinter.PrintLine("  (1) Olive Green");
                    ZorkPrinter.PrintLine("  (2) Red");
                    ZorkPrinter.PrintLine("  (3) Dark Blue");
                    ZorkPrinter.PrintLine("  (4) Purple\n");
                }

                ZorkPrinter.Print("\n:> ");
                string input = Console.ReadLine();
                ZorkPrinter.PrintLine("");

                if (int.TryParse(input, out int option))
                {
                    if (option == 1 ||
                        option == 2 ||
                        option == 3 ||
                        option == 4)
                    {
                        if (option == 2 &&
                            currentQuestion == 1) 
                        { 
                            ZorkPrinter.PrintLine("Correct! Acting is very easy, anyone can do it\n", ZorkPrinter.PlayerColour);
                            currentQuestion++;
                        }
                        else if (option == 3 &&
                            currentQuestion == 2)
                        {
                            ZorkPrinter.PrintLine("Correct! Mint Flavour is Disgusting\n", ZorkPrinter.PlayerColour);
                            currentQuestion++;
                        }
                        else if (option == 4 &&
                            currentQuestion == 3)
                        {
                            ZorkPrinter.PrintLine("Correct! ", ZorkPrinter.PlayerColour);
                            ZorkPrinter.PrintLine("Quiz Complete! \n", ZorkPrinter.PlayerColour);
                            return true;
                        }
                        else
                        {
                            ZorkPrinter.PrintLine("Incorrect!!", ZorkPrinter.NPCColour);
                            ZorkPrinter.PrintLine("Try Again\n", ZorkPrinter.NPCColour);
                            return false;
                        }
                    }
                }
            }

            return true;
            
        }
    }
}

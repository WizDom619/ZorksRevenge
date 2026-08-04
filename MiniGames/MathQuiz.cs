using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.MiniGames
{
    public class MathQuiz : MiniGame
    {
        private bool _isPlaying = true;

        public override bool Play()
        {
            // Circumference
            // Answer = 81.68141
            float answer = 81.681f;

            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            ZorkPrinter.PrintLine("Minigame #4 Math Quiz");
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");

            ZorkPrinter.PrintLine("Please answer the following math questions...\n");
            ZorkPrinter.PrintLine("    -Question 1\n");
            

            while (_isPlaying)
            {
                ZorkPrinter.Print("What is the ");
                ZorkPrinter.Print("Circumfrence", ConsoleColor.DarkYellow, PrintEffect.Underline);
                ZorkPrinter.PrintLine(" of the following Circle?");
                ZorkPrinter.PrintLine("Please give your answer to the 3rd degree. \n");

                Console.WriteLine("             ****************");
                Console.WriteLine("         ****                ****");
                Console.WriteLine("       ***                      ***");
                Console.WriteLine("     **                            **");
                Console.WriteLine("   ***                              ***");
                Console.WriteLine("  ***                                ***");
                Console.WriteLine("  **                                  **");
                Console.WriteLine(" **                         13         **");
                Console.WriteLine(" **                  o-----------------**");
                Console.WriteLine(" **                                    **");
                Console.WriteLine(" **                                    **");
                Console.WriteLine("  **                                  **");
                Console.WriteLine("  ***                                ***");
                Console.WriteLine("   ***                              ***");
                Console.WriteLine("    **                            **");
                Console.WriteLine("       ***                      ***");
                Console.WriteLine("         ****                ****");
                Console.WriteLine("             ****************");

                ZorkPrinter.Print(":> ");
                string input = Console.ReadLine();
                ZorkPrinter.PrintLine("");

                if (!float.TryParse(input, out float _guess))
                {
                    ZorkPrinter.PrintLine("That's not a valid number.\n");
                }                
                else if (_guess != answer)
                {
                    ZorkPrinter.PrintLine("Incorrect, guess again\n");
                }
                else
                {
                    ZorkPrinter.PrintLine("Correct!\n", ConsoleColor.Green);
                    _isPlaying = false;
                }
                ZorkPrinter.PrintLine("-----------------------------------------\n");
            }

            //Area of a Circle,
            _isPlaying = true;
            answer = 18626.503f;

            ZorkPrinter.PrintLine("Please answer the following math questions...\n");
            ZorkPrinter.PrintLine("    -Question 2\n");

            while(_isPlaying)
            {
                ZorkPrinter.Print("What is the ");
                ZorkPrinter.Print("Area", ConsoleColor.DarkYellow, PrintEffect.Underline);
                ZorkPrinter.PrintLine(" of the following circle?");
                ZorkPrinter.PrintLine("Please give your answer to the 3rd degree. \n");

                Console.WriteLine("             ****************");
                Console.WriteLine("         ****                ****");
                Console.WriteLine("       ***                      ***");
                Console.WriteLine("     **                            **");
                Console.WriteLine("   ***                              ***");
                Console.WriteLine("  ***                                ***");
                Console.WriteLine("  **                                  **");
                Console.WriteLine(" **                         77         **");
                Console.WriteLine(" **                  o-----------------**");
                Console.WriteLine(" **                                    **");
                Console.WriteLine(" **                                    **");
                Console.WriteLine("  **                                  **");
                Console.WriteLine("  ***                                ***");
                Console.WriteLine("   ***                              ***");
                Console.WriteLine("    **                            **");
                Console.WriteLine("       ***                      ***");
                Console.WriteLine("         ****                ****");
                Console.WriteLine("             ****************");

                ZorkPrinter.Print(":> ");
                string input = Console.ReadLine();
                ZorkPrinter.PrintLine("");

                if (!float.TryParse(input, out float _guess))
                {
                    ZorkPrinter.PrintLine("That's not a valid number\n");
                    continue;
                }
                else if (_guess != answer)
                {
                    ZorkPrinter.PrintLine("Incorrect, guess again\n");
                }
                else
                {
                    ZorkPrinter.PrintLine("Correct!", ConsoleColor.Green);
                    _isPlaying = false;
                }
                ZorkPrinter.PrintLine("-----------------------------------------\n");
            }

            //Hypotenuse Calculator
            _isPlaying = true;
            answer = 602.540f;

            ZorkPrinter.PrintLine("Please answer the following math questions...\n");
            ZorkPrinter.PrintLine("    -Question 3\n");

            while (_isPlaying)
            {
                ZorkPrinter.Print("What is the ");
                ZorkPrinter.Print("Hypotenuse", ConsoleColor.DarkYellow, PrintEffect.Underline);
                ZorkPrinter.PrintLine(" of the following Triangle?");
                ZorkPrinter.PrintLine("Please give your answer to the 3rd degree. \n");

                Console.WriteLine("         *");
                Console.WriteLine("         **");
                Console.WriteLine("         * *");
                Console.WriteLine("         *  *");
                Console.WriteLine("         *   *");
                Console.WriteLine("         *    *");
                Console.WriteLine("         *     *");
                Console.WriteLine("         *      *");
                Console.WriteLine("         *       *");
                Console.WriteLine(" 23.467  *        *");
                Console.WriteLine("         *         *      ??");
                Console.WriteLine("         *          *");
                Console.WriteLine("         *           *");
                Console.WriteLine("         *            *");
                Console.WriteLine("         *             *");
                Console.WriteLine("         *              *");
                Console.WriteLine("         *               *");
                Console.WriteLine("         *                *");
                Console.WriteLine("         *                 *");
                Console.WriteLine("         ********************");
                Console.WriteLine("                 7.2");

                ZorkPrinter.Print(":> ");
                string input = Console.ReadLine();
                ZorkPrinter.PrintLine("");

                if (!float.TryParse(input, out float _guess))
                {
                    ZorkPrinter.PrintLine("That's not a valid number\n");
                    continue;
                }
                else if (_guess != answer)
                {
                    ZorkPrinter.PrintLine("Incorrect, guess again\n");
                }
                else
                {
                    ZorkPrinter.PrintLine("Correct!", ConsoleColor.Green);
                    _isPlaying = false;
                }
                ZorkPrinter.PrintLine("-----------------------------------------\n");
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.MiniGames
{
    internal class MathQuiz : MiniGame
    {
        private bool _isPlaying = true;

        public override bool Play()
        {
            // Circumference
            // Answer = 81.68141
            float answer = 81.68141f;

            ZorkPrinter.PrintLine("Please answer the following math questions...\n");
            ZorkPrinter.PrintLine("    -Question 1\n");
            

            while (_isPlaying)
            {
                ZorkPrinter.PrintLine("What is the circumfrence of the following circle?");
                ZorkPrinter.PrintLine("Please give your answer to the 5th degree. \n");

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

                Console.Clear();

                if (!float.TryParse(input, out float _guess))
                {
                    ZorkPrinter.PrintLine("That's not a valid number.");
                    continue;
                }
                
                if (_guess != answer)
                {
                    ZorkPrinter.PrintLine("Incorrect, guess again");
                }
                else
                {
                    ZorkPrinter.PrintLine("Correct!", ConsoleColor.Green);
                    _isPlaying = false;
                }
            }

            //Area of a Circle,
            _isPlaying = true;
            answer = 18626.50284f;

            ZorkPrinter.PrintLine("Please answer the following math questions...\n");
            ZorkPrinter.PrintLine("    -Question 2\n");

            while(_isPlaying)
            {
                ZorkPrinter.PrintLine("What is the area of the following circle?");
                ZorkPrinter.PrintLine("Please give your answer to the 5th degree. \n");

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

                Console.Clear();

                if (!float.TryParse(input, out float _guess))
                {
                    ZorkPrinter.PrintLine("That's not a valid number.");
                    continue;
                }

                if (_guess != answer)
                {
                    ZorkPrinter.PrintLine("Incorrect, guess again");
                }
                else
                {
                    ZorkPrinter.PrintLine("Correct!", ConsoleColor.Green);
                    _isPlaying = false;
                }
            }

            //Hypotenuse Calculator
            _isPlaying = true;
            answer = 602.54009f;

            ZorkPrinter.PrintLine("Please answer the following math questions...\n");
            ZorkPrinter.PrintLine("    -Question 3\n");

            while (_isPlaying)
            {
                ZorkPrinter.PrintLine("What is the hypotenuse of the following triangle?");
                ZorkPrinter.PrintLine("Please give your answer to the 5th degree. \n");

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

                Console.Clear();

                if (!float.TryParse(input, out float _guess))
                {
                    ZorkPrinter.PrintLine("That's not a valid number.");
                    continue;
                }

                if (_guess != answer)
                {
                    ZorkPrinter.PrintLine("Incorrect, guess again");
                }
                else
                {
                    ZorkPrinter.PrintLine("Correct!", ConsoleColor.Green);
                    _isPlaying = false;
                }
            }

            return true;
        }
    }
}

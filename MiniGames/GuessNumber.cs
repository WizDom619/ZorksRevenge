using ZorksRevenge.MiniGames;

namespace ZorksRevenge
{       
    public class GuessNumber : MiniGame
    {
        private int _number;
        private int _guesses = 7;
        private bool _isPlaying = true;

        public override bool Play()
        {
            bool result = false;
            _isPlaying = true;
            _guesses = 7;

            Random random = new Random();
            _number = random.Next(1, 101); // 1 to 100 inclusive

            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            ZorkPrinter.PrintLine("Minigame #1 Guess my Number");
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");

            ZorkPrinter.PrintLine("I have chosen a random number from 1 to 100");
            ZorkPrinter.PrintLine("Please guess my number");
            ZorkPrinter.PrintLine($"  You have {_guesses} guesses left...\n");

            while (_isPlaying)
            {                
                ZorkPrinter.Print($":> ");

                string input = Console.ReadLine();

                ZorkPrinter.PrintLine($"");

                if (!int.TryParse(input, out int guess))
                {
                    ZorkPrinter.PrintLine("That's not a valid number.");
                    continue;
                }
                else
                {
                    _guesses--;

                    if (guess == _number)
                    {
                        ZorkPrinter.PrintLine($"Correct! The number was {_number}.\n", ZorkPrinter.PlayerColour);
                        _isPlaying = false;
                        result = true;
                    }
                    else if (_guesses <= 0)
                    {
                        ZorkPrinter.PrintLine($"Out of guesses! The number was {_number}.\n");
                        _isPlaying = false;
                        result = false;
                    }
                    else if (guess < _number)
                    {
                        ZorkPrinter.Print("Higher!  ");
                        ZorkPrinter.PrintLine($"You have {_guesses} guesses left...\n");
                    }
                    else
                    {
                        ZorkPrinter.Print("Lower!  ");
                        ZorkPrinter.PrintLine($"You have {_guesses} guesses left...\n");
                    }
                }                
            }

            return result;
        }
    }
}

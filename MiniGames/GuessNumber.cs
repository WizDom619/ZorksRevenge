namespace ZorksRevenge.MiniGames
{
    internal class GuessNumber : MiniGame
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

            ZorkPrinter.PrintLine("Let's play a guess the number game");
            ZorkPrinter.PrintLine("I have chosen a random number from 1 to 100");
            ZorkPrinter.PrintLine("Please guess my number");
            ZorkPrinter.PrintLine($"You have {_guesses} guesses left...\n");

            // TESTING
            ZorkPrinter.PrintLine($"Answer is {_number}");
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
                        ZorkPrinter.PrintLine("Correct!");
                        _isPlaying = false;
                        result = true;
                    }
                    else if (_guesses <= 0)
                    {
                        ZorkPrinter.PrintLine($"Out of guesses! The number was {_number}.");
                        _isPlaying = false;
                        result = false;
                    }
                    else if (guess < _number)
                    {
                        ZorkPrinter.PrintLine("Higher!\n");
                        ZorkPrinter.PrintLine($"You have {_guesses} guesses left...\n");
                    }
                    else
                    {
                        ZorkPrinter.PrintLine("Lower!\n");
                        ZorkPrinter.PrintLine($"You have {_guesses} guesses left...\n");
                    }
                }                
            }

            return result;
        }
    }
}

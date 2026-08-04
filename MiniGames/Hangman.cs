using ZorksRevenge.MiniGames;

namespace ZorksRevenge  
{
    public class Hangman : MiniGame
    {
        bool _isPlaying = true;

        int _drawCount = 0;

        List<char> _wrongLetters = new List<char>();
        Dictionary<char, bool> _rightLetters = new Dictionary<char, bool>();

        public Hangman()
        {
            //Wellington 
            _rightLetters.Add('N', false);
            _rightLetters.Add('I', false);
            _rightLetters.Add('C', false);
            _rightLetters.Add('O', false);
            _rightLetters.Add('D', false);
            _rightLetters.Add('E', false);
            _rightLetters.Add('M', false);
            _rightLetters.Add('U', false);
            _rightLetters.Add('S', false);
        }

        public override bool Play()
        {
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
            ZorkPrinter.PrintLine("Minigame #3 Hangman");
            ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");
            ZorkPrinter.PrintLine("Guess my word...\n");

            _drawCount = 0;
            _isPlaying = true;
            _wrongLetters.Clear();

            _rightLetters['N'] = false;
            _rightLetters['I'] = false;
            _rightLetters['C'] = false;
            _rightLetters['O'] = false;
            _rightLetters['D'] = false;
            _rightLetters['E'] = false;
            _rightLetters['M'] = false;
            _rightLetters['U'] = false;
            _rightLetters['S'] = false;

            foreach (KeyValuePair<char, bool> kvp in _rightLetters)
            {
                _rightLetters[kvp.Key] = false;
            }

            while (_isPlaying)
            {
                foreach (KeyValuePair<char, bool> kvp in _rightLetters)
                { 
                    if (kvp.Value == false)
                    {
                        ZorkPrinter.Print("_ ");
                    }
                    else
                    {
                        ZorkPrinter.Print(kvp.Key + " ");
                    }
                }
                ZorkPrinter.PrintLine("");   
                ZorkPrinter.PrintLine("");   
                ZorkPrinter.Print("Incorrect Letters: ");     
                
                foreach (char c in _wrongLetters)
                {
                    ZorkPrinter.Print(c.ToString() + " ");
                }

                ZorkPrinter.PrintLine("");

                DrawHangman();

                ZorkPrinter.PrintLine("");

                ZorkPrinter.Print(":> ");
                string input = Console.ReadLine().ToUpper();
                ZorkPrinter.PrintLine("");

                if (char.TryParse(input, out char playerGuess))
                {
                    bool isRightLetter = false; 

                    foreach (KeyValuePair<char, bool> kvp in _rightLetters)
                    {
                        if (playerGuess == kvp.Key)
                        {
                            _rightLetters[kvp.Key] = true;
                            isRightLetter = true;
                        }
                    }

                    if (!isRightLetter)
                    {
                        if (!_wrongLetters.Contains(playerGuess))
                        {
                            _drawCount++;
                            _wrongLetters.Add(playerGuess);
                        }
                    }
                }
                else
                {
                    ZorkPrinter.PrintLine("Invalid Input\n");
                }

                bool gameOver = true; 

                foreach (KeyValuePair<char, bool> kvp in _rightLetters)
                {
                    if (kvp.Value == false)
                    {
                        gameOver = false; 
                    }                        
                }

                if (gameOver == true)
                {
                    _isPlaying = false;
                }

                if (_drawCount == 6)
                {
                    DrawHangman();
                    ZorkPrinter.PrintLine($"You Lose!\n", ZorkPrinter.NPCColour);
                    return false;
                }
            }
            ZorkPrinter.PrintLine("Correct!\n", ZorkPrinter.PlayerColour);
            return true;
        }

        private void DrawHangman()
        {
            if (_drawCount == 0)
            {
                ZorkPrinter.PrintLine("  _______");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine(" _|___");
            }

            if (_drawCount == 1)
            {
                ZorkPrinter.PrintLine("  _______");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |      O");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine(" _|___");
            }

            if (_drawCount == 2)
            {
                ZorkPrinter.PrintLine("  _______");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |      O");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine(" _|___");
            }

            if (_drawCount == 3)
            {
                ZorkPrinter.PrintLine("  _______");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |      O");
                ZorkPrinter.PrintLine("  |     /|");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine(" _|___");
            }

            if (_drawCount == 4)
            {
                ZorkPrinter.PrintLine("  _______");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |      O");
                ZorkPrinter.PrintLine("  |     /|\\");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine(" _|___");
            }

            if (_drawCount == 5)
            {
                ZorkPrinter.PrintLine("  _______");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |      O");
                ZorkPrinter.PrintLine("  |     /|\\");
                ZorkPrinter.PrintLine("  |     /");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine(" _|___");
            }

            if (_drawCount == 6)
            {
                ZorkPrinter.PrintLine("  _______");
                ZorkPrinter.PrintLine("  |      |");
                ZorkPrinter.PrintLine("  |      O");
                ZorkPrinter.PrintLine("  |     /|\\");
                ZorkPrinter.PrintLine("  |     / \\");
                ZorkPrinter.PrintLine("  |");
                ZorkPrinter.PrintLine(" _|___");
            }

            ZorkPrinter.PrintLine($"-----------------------------\n");
        }
    }
}

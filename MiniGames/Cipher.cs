namespace ZorksRevenge.MiniGames
{
    internal class Cipher : MiniGame
    {
        public override bool Play()
        {
            bool result = false;
            bool _isPlaying = false;

            // Game settings
            string normalText = "You figured out what a Cipher is, this puzzle dates all the way back to ancient Rome. please type the word pizza";
            string answer = "PIZZA";
            int shiftKey = 5;
            string encryptedText = Encrypt(normalText, shiftKey);


            ZorkPrinter.PrintLine("Let's play a Cipher Game!");
            ZorkPrinter.PrintLine("Here is a Encrypted message...\n");
            ZorkPrinter.PrintLine($"    {encryptedText}\n", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine($"Hint: +5, and remember this is a Cipher\n");

            while (!_isPlaying)
            {
                ZorkPrinter.Print(":> ");
                string playerGuess = Console.ReadLine().ToUpper();

                if (playerGuess == answer)
                {
                    ZorkPrinter.PrintLine("Success! You decrypted the word!\n");
                    _isPlaying = true;
                    result = true;
                }
                else
                {
                    ZorkPrinter.PrintLine("Incorrect. Try again!\n");
                }
            }
            return result;
        }

        // Encrypt method using the Caesar cipher technique
        static string Encrypt(string input, int shift)
        {
            char[] buffer = input.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    // Shifts the letter within the alphabet and loops around if needed
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((letter + shift - offset) % 26 + offset);
                }

                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}

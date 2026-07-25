using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.MiniGames
{
    internal class WordSearch : MiniGame
    {
        bool _isFaithFound = false; 
        bool _isBibleFound = false; 
        bool _isRegenerationFaithFound = false;
        bool _isPlaying = true;

        public override bool Play()
        {
            while (_isPlaying)
            {
                ZorkPrinter.PrintLine("Let's do a Word Search");
                ZorkPrinter.PrintLine("Find the three hidden word...\n");

                Console.WriteLine("O R L T G Y V D G C V Q A B F N Q T D G G Y G A F B Y L T O X G V W G J O J N Q G U J D C G J A N K");
                Console.WriteLine("A H W I F I K U S N O O J O Q P I B J A A M U K S K M A E K G K G L I P R U Q N M C E H E V D D T M");
                Console.WriteLine("B E L R Y X B I B L E J X B C Z V P F W B W E L D Q H S Z B M S Z E S L U G H I V B M D T A V B V A");
                Console.WriteLine("N B X Q X L V Z X D H C D Y B E Y E D W M B U B O L E S Q C E M V Z L U W D A Y T A V Q C M I W J P");
                Console.WriteLine("L R N B I B H G S G W L B X L K G L A U O J H A Q W K N X R P T R B Z Y F F N L M T W Z J I N N E T");
                Console.WriteLine("G I W W Y F X R I H O F P S O M M Q F X I F Z A H K C I P P A N J X K B G A F L O N J N W P A P Z P");
                Console.WriteLine("X V V J B O Z K P R U O A P A P F W Z H J T E L X R B R S U O W V T V W A I H Q R Y A T B U Z K Y Y");
                Console.WriteLine("E R K D I H K L Y Z U J B N Q E P W L C R P K L P S Z D Q O B U K E K B A T N W X G X S L B X M R V");
                Console.WriteLine("U M W M I M S R Z R N C X G G S O V T J F Z C J P D Z T D E L V F I G X M H R S K F N D Y I O Q Z P");
                Console.WriteLine("H D P X R F N J O E R E G E N E R A T I O N F M U D N J H Z L S N T Q Z Z M X D R I Y E R F I B O V");
                Console.WriteLine("R I Q J E Q H K Z R E S Y C T V G Y E R J F I V Z C S B A Q G Z G J K H E Q O Z O Z F G M Z I F H I");
                Console.WriteLine("L Y X R A A U N P Y W M V W T I H K Z Y W I K G G V D T Z C M Y D U L G I D X X U W P O R A E Z F K");

                ZorkPrinter.PrintLine("");

                ZorkPrinter.Print(":> ");
                string playerGuess = Console.ReadLine().ToUpper();

                Console.Clear();

                if (playerGuess == "FAITH")
                {
                    _isFaithFound = true;
                    ZorkPrinter.PrintLine("Correct, Faith is found", ConsoleColor.Green);
                }
                else if (playerGuess == "BIBLE")
                {
                    _isBibleFound = true;
                    ZorkPrinter.PrintLine("Correct, Bible is found", ConsoleColor.Green);
                }
                else if (playerGuess == "REGENERATION")
                {
                    _isRegenerationFaithFound = true;
                    ZorkPrinter.PrintLine("Correct, Regeneration is found", ConsoleColor.Green);
                }
                else
                {
                    ZorkPrinter.PrintLine("Incorrect");
                }


                if (_isFaithFound &&
                    _isBibleFound &&
                    _isRegenerationFaithFound)
                {
                    _isPlaying = false;
                }
            }
           
            return true;
        }
    }
}

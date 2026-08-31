using ZorksRevenge.Utility;


namespace ZorksRevenge.MiniGames
{
    public class WordSearch : MiniGame
    {
        bool _isFaithFound = false; 
        bool _isBibleFound = false; 
        bool _isRegenerationFound = false;
        bool _isPlaying = true;

        public override bool Play()
        {
            while (_isPlaying)
            {
                ZorkPrinter.PrintLine("-----------------------------------------------------------------------");
                ZorkPrinter.PrintLine("Minigame #5 Word Search");
                ZorkPrinter.PrintLine("-----------------------------------------------------------------------\n");
                ZorkPrinter.PrintLine("Find the x3 hidden word...\n");

                Console.WriteLine("F S Z t i w K e b P g q B c I Q M t k F P B");
                Console.WriteLine("O p f J B j Y U l F c y N N I m C F q l t j");
                Console.WriteLine("E k Y r I g Q n p y I A b J B Y f u X J w C");
                Console.WriteLine("S x d S B G P b i C v R N y F A I T H H A E");
                Console.WriteLine("a l d x L V C Z N L Q X k Q F E M K o J D a");
                Console.WriteLine("o o Y N E b B o d D E y o L N V R q z J D r");
                Console.WriteLine("D C g Q F R V B y j V W x y q r Q T F S B L");
                Console.WriteLine("a w w Q n q I n m r o v t h f A R S q J A p");
                Console.WriteLine("k A w T R h q o N c o M J a h M z N B r m R");
                Console.WriteLine("n q A c R h Y R E G E N E R A T I O N V T i");
                Console.WriteLine("G v s w w c j A R L z a m y G M u N Y P c q");
                Console.WriteLine("Z J i F A b A D c C g i W a i T c q s I M U");

                ZorkPrinter.PrintLine("");

                ZorkPrinter.Print(":> ");
                string playerGuess = Console.ReadLine().ToUpper();
                ZorkPrinter.PrintLine("");

                if (playerGuess == "FAITH")
                {
                    _isFaithFound = true;
                    ZorkPrinter.PrintLine("Correct, Faith is found\n", ConsoleColor.Green);
                }
                else if (playerGuess == "BIBLE")
                {
                    _isBibleFound = true;
                    ZorkPrinter.PrintLine("Correct, Bible is found\n", ConsoleColor.Green);
                }
                else if (playerGuess == "REGENERATION")
                {
                    _isRegenerationFound = true;
                    ZorkPrinter.PrintLine("Correct, Regeneration is found\n", ConsoleColor.Green);
                }
                else
                {
                    ZorkPrinter.PrintLine("Incorrect\n", ZorkPrinter.NPCColour);
                }

                if (_isFaithFound &&
                    _isBibleFound &&
                    _isRegenerationFound)
                {
                    _isPlaying = false;
                }
            }
           
            return true;
        }
    }
}

using System.Data;
using System.Runtime.CompilerServices;
using ZorksRevenge.GameStates.MenuItems;

namespace ZorksRevenge.MiniGames
{
    internal class FinalBoss : MiniGame
    {
        private bool _isSelecting = true;
        private string _response = "0";

        private int _domHP = 100;
        private int _playerHP = 100;

        private int _hits = 6;

        public override bool Play()
        {
            Console.Clear();
           
            ZorkPrinter.Print("\"Hehe, thank you for all the six gems\" says ");
            ZorkPrinter.PrintLine("Dominic", ZorkPrinter.NPCColour);
            ZorkPrinter.PrintLine("\"Thanks to you and the power of the six games my plan for world domination is at hand\"");
            ZorkPrinter.PrintLine("\"hahahahahahahaha\"");
            ZorkPrinter.PrintLine("\"I will kill you now...\"\n\n");

            ZorkPrinter.PrintLine("Out of the shadows jumps two Pokemon ninjas!");
            ZorkPrinter.PrintLine("Bono and Beastcilla", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine("\"You can count on us for help!\"\n");

            Console.WriteLine("-----------------------------------------------");
            ZorkPrinter.PrintLine("                 Begin Battle              ");
            Console.WriteLine("-----------------------------------------------\n");

            UpdateStats();
            Turn1();
            Turn2();
            Turn3();
            Turn4();
            Turn5();
            Turn6();

            ZorkPrinter.PrintEnd();
            while (true)
            {
                
            }

            

            return true;
        }

        private void UpdateStats()
        {
            ZorkPrinter.PrintLine($"Player's HP: {_playerHP} / 100", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine($"Dominic's HP: {_domHP} / 100\n", ZorkPrinter.NPCColour);
        }

        private void Turn1()
        {
            ZorkPrinter.PrintLine("Bono releases Umbreon!", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine("    (1) Wish"); // Large Healing
            ZorkPrinter.PrintLine("    (2) Protect"); // Defence
            ZorkPrinter.PrintLine("    (3) Foul Play");// Big Hit
            ZorkPrinter.PrintLine("    (4) Dark Pulse"); // Hit

            ZorkPrinter.Print("\n:> ");
            string _response = Console.ReadLine();
            Console.Clear();

            if (_response != "1" ||
                _response != "2" ||
                _response != "3" ||
                _response != "4")
            {

                switch (_response)
                {
                    case "1":
                        _playerHP += 15;
                        ZorkPrinter.PrintLine("Umbreon uses Wish to heal player by 15pts");
                        break;

                    case "2":
                        ZorkPrinter.PrintLine("Umbreon gets ready to protect player");
                        break;

                    case "3":
                        _domHP -= 20;
                        ZorkPrinter.PrintLine("Umbreon attacks with Foul Play for 20pts");
                        break;

                    case "4":
                        _domHP -= 15;
                        ZorkPrinter.PrintLine("Umbreon attacks for Dark Pulse for 15pts");
                        break;

                    default:
                        break;
                }

                ZorkPrinter.PrintLine("");

                if (_response == "2")
                {
                    ZorkPrinter.PrintLine("Dominic's attack was blocked by Umbreon");
                }
                else
                {
                    _playerHP -= 20;
                    ZorkPrinter.PrintLine("Dominic attacks for 20pts");
                }
            }

            ZorkPrinter.PrintLine("");

            UpdateStats();
        }

        private void Turn2() 
        {
            ZorkPrinter.PrintLine("Beastcilla releases Lickitung!", ZorkPrinter.PlayerColour);
            ZorkPrinter.PrintLine("    (1) Body Slam"); // Big attack, stun
            ZorkPrinter.PrintLine("    (2) Seismic Toss"); // Big Attack
            ZorkPrinter.PrintLine("    (3) Rest");// Back to 100
            ZorkPrinter.PrintLine("    (4) Roll Out"); // Hit

            ZorkPrinter.Print("\n:> ");
            string _response = Console.ReadLine();
            Console.Clear();

            if (_response != "1" ||
                _response != "2" ||
                _response != "3" ||
                _response != "4")
            {

                switch (_response)
                {
                    case "1":
                        _domHP -= 25;
                        ZorkPrinter.PrintLine("Lickitung uses Body Slam to hit for 25pts");
                        break;

                    case "2":
                        _domHP -= 22;
                        ZorkPrinter.PrintLine("Lickitung used Seismic Toss to hit for 22pts");
                        break;

                    case "3":
                        _playerHP = 100;
                        ZorkPrinter.PrintLine("Lickitung uses Rest, heals you back to 100HP");
                        break;

                    case "4":
                        _domHP -= 15;
                        ZorkPrinter.PrintLine("Lickitung uses Roll Out to hit for 20pts");
                        break;

                    default:
                        break;
                }

                ZorkPrinter.PrintLine("");

                if (_response == "1")
                {
                    ZorkPrinter.PrintLine("Dominic is paralyzed this turn");
                }
                else
                {
                    _playerHP -= 20;
                    ZorkPrinter.PrintLine("Dominic attacks for 20pts");
                }
            }

            ZorkPrinter.PrintLine("");

            UpdateStats();
        }
        private void Turn3() { }
        private void Turn4() { }
        private void Turn5() { }
        private void Turn6() { }
    }
}

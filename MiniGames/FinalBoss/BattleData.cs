using ZorksRevenge.MiniGames.FinalBoss;
using ZorksRevenge.MiniGames.FinalBoss.Attributes;
using ZorksRevenge.Utility;

namespace ZorksRevenge
{
    public static class BattleData
    {
        private static List<Trainer> _trainers = new List<Trainer>();

        private static Trainer _curTrainer;

        private static int _playerHP = 100;
        private static int _enemyHP = 100;

        private static string _enemyStatus = "null";

        public static void Initialize()
        {
            _playerHP = 100;
            _enemyHP = 100;
            _enemyStatus = "null";

            _trainers.Add(new Trainer("Jono")
                .AddPokemon(new Pokemon("Umbreon")
                    .AddMove(new Move("Wish", "to heal player by 15pts")
                    .AddAttributes(new Heal(15)))
                    .AddMove(new Move("Protect", "and is ready to protect player")
                        .AddAttributes(new Stun()))
                    .AddMove(new Move("Foul Play", "to hit for 20pts")
                        .AddAttributes(new Hit(-20)))
                    .AddMove(new Move("Dark Pulse", "to hit for 15pts")
                        .AddAttributes(new Hit(-15))))
                
                .AddPokemon(new Pokemon("Gengar")
                    .AddMove(new Move("Shadow Ball", "to hit for 18pts")
                        .AddAttributes(new Hit(-18)))
                    .AddMove(new Move("Sludge Bomb", "to hit for 22pts")
                        .AddAttributes(new Hit(-22)))
                    .AddMove(new Move("Focus Blast", "to hit for 15pts")
                        .AddAttributes(new Hit(-15)))
                    .AddMove(new Move("Ice Wind", "to hit for 7pts")
                        .AddAttributes(new Hit(-7))
                        .AddAttributes(new Stun())))

                .AddPokemon(new Pokemon("Flygon")
                    .AddMove(new Move("Earthquake", "to hit for 18pts")
                        .AddAttributes(new Hit(-18)))
                    .AddMove(new Move("Sludge Bomb", "to hit for 22pts")
                        .AddAttributes(new Hit(-22)))
                    .AddMove(new Move("Focus Blast", "to hit for 15pts")
                        .AddAttributes(new Hit(-15)))
                    .AddMove(new Move("Ice Wind", "to hit for 7pts")
                        .AddAttributes(new Hit(-7))
                        .AddAttributes(new Stun())))

                );

            _trainers.Add(new Trainer("Beastcilla")
                .AddPokemon(new Pokemon("Tinkatink")
                    .AddMove(new Move("Play Rough", "to hit for 20pts")
                        .AddAttributes(new Hit(-20)))
                    .AddMove(new Move("Metal Claw", "to hit for 16pt")
                        .AddAttributes(new Hit(-16)))
                    .AddMove(new Move("Thunder Wave", "to Stun Dominic")
                        .AddAttributes(new Stun()))
                    .AddMove(new Move("Protect", "and is ready to protect player")
                        .AddAttributes(new Stun())))

                .AddPokemon(new Pokemon("Lickitung")
                    .AddMove(new Move("Body Slam", "to hit for 25pts")
                        .AddAttributes(new Hit(-25))
                        .AddAttributes(new Stun()))                        
                    .AddMove(new Move("Seismic Toss", "to hit for 22pts")
                        .AddAttributes(new Hit(-22)))                        
                    .AddMove(new Move("Rest", "heals you back to 100HP")
                        .AddAttributes(new FullHeal()))
                    .AddMove(new Move("Roll Out", "to hit for 20pt")
                        .AddAttributes(new Hit(-20))))

                .AddPokemon(new Pokemon("Psyduck")
                    .AddMove(new Move("Water Gun", "to hit for 15pts")
                        .AddAttributes(new Hit(-15)))
                    .AddMove(new Move("Scratch", "to hit for 2pt")
                        .AddAttributes(new Hit(-2)))
                    .AddMove(new Move("Hypnosis", "to stun Dominic")
                        .AddAttributes(new Stun()))
                    .AddMove(new Move("Surf", "to hit for 20pts")
                        .AddAttributes(new Hit(-20))))

                

                ); 

            _curTrainer = _trainers.Find(t => t.Name == "Jono");
        }

        public static void EnemyTurn()
        {
            if (_enemyStatus == "Stun")
            {
                _enemyStatus = "null";
                ZorkPrinter.PrintLine($"Zork was stunned by {_curTrainer.CurPokemon.Name}");
            }
            else
            {
                _playerHP -= 10;
                ZorkPrinter.PrintLine("Zork attacks for 10pts");
            }
        }

        public static void UpdateEnemyStatus(string status)
        {
            _enemyStatus = status;
        }

        public static void UpdatePlayerHP(int hp)
        {
            _playerHP += hp;
        }

        public static void UpdateEnemyHP(int hp)
        {
            _enemyHP += hp;
        }

        

        public static void UpdateTrainer()
        {
            if (_curTrainer.Name == "Jono")
            {
                _curTrainer = _trainers.Find(t => t.Name == "Beastcilla");
            }
            else if (_curTrainer.Name == "Beastcilla")
            {
                _curTrainer = _trainers.Find(t => t.Name == "Jono");
            }
            else
            {
                ZorkPrinter.PrintLine("Trainer NULL");
            }
            _curTrainer.GetNextPokemon();
        }

        public static Trainer CurTrainer { get { return _curTrainer; } }
        public static Pokemon CurPokemon { get { return _curTrainer.CurPokemon; } }
        public static int PlayerHP {  get { return _playerHP; } }
        public static int EnemyHP {  get { return _enemyHP; } }

        
    }
}

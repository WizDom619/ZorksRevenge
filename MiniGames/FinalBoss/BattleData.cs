using ZorksRevenge.MiniGames.FinalBoss.Attributes;
using ZorksRevenge.Utility;

namespace ZorksRevenge.MiniGames.FinalBoss
{
    public static class BattleData
    {
        // There will only be two trainers in this Pokemon battle. 
        public static List<Trainer> Trainers = new List<Trainer>();
        public static Trainer CurTrainer { get; private set; }
        public static Pokemon CurPokemon { get; private set; }

        // Both players will start with 100hp
        public static int PlayerHP { get; private set; } = 100;
        public static int EnemyHP { get; private set; } = 100;

        // And Zork will have not status effect.
        private static Status _enemyStatus = Status.NULL; 

        public static void Init()
        {
            // The First Trainer will be Jono
            // Jono has a Umbreon, Gengar and a Flygon. 
            Trainers.Add(new Trainer("Jono")
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

            // The second trainer will be Beastcilla
            // Beastcilla will have a Tinkatink, Lickitung and a Psyduck
            Trainers.Add(new Trainer("Beastcilla")
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

            CurTrainer = Trainers.Find(t => t.Name == "Jono");
        }

        // The method processess the Zork's turn. 
        public static void EnemyTurn()
        {
            // If the status is Stun then Zork skips a turn. 
            if (_enemyStatus == Status.Stun)
            {
                _enemyStatus = Status.NULL;
                ZorkPrinter.PrintLine($"Zork was stunned by {CurTrainer.CurPokemon.Name}");
            }
            // Otherwise Zork will hit for 10 dmg. 
            else
            {
                PlayerHP -= 10;
                ZorkPrinter.PrintLine("Zork attacks for 10pts");
            }
        }

        public static void UpdateEnemyStatus(Status status)
        {
            _enemyStatus = status;
        }

        public static void UpdatePlayerHP(int hp)
        {
            PlayerHP += hp;
        }

        public static void UpdateEnemyHP(int hp)
        {
            EnemyHP += hp;
        }        

        // If trainer is Jono then swap to Beastcilla, otherwise swap back to Jono. 
        // We will keep alternating trainers and rotating through each Pokemon. 
        public static void UpdateTrainer()
        {
            if (CurTrainer.Name == "Jono")
            {
                CurTrainer = Trainers.Find(t => t.Name == "Beastcilla");
            }
            else if (CurTrainer.Name == "Beastcilla")
            {
                CurTrainer = Trainers.Find(t => t.Name == "Jono");
            }
            else
            {
                // An errors has occured and can't find a trainer's name. 
                ZorkPrinter.PrintLine("ERROR: Trainer NULL");
            }
            // Get the next of 3 Pokemon of each trainer. 
            CurTrainer.GetNextPokemon();
        }        
    }
}
